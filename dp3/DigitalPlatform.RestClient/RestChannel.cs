using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;

namespace DigitalPlatform.RestClient
{
    public class RestChannel
    {
        /// dp2Library 服务器的 URL
        public string Url { get; set; }
        public string UserName { get; set; }

        /// <summary>
        /// 当前通道所使用的 HTTP Cookies
        /// </summary>
        public CookieContainer _cookies = new CookieContainer();

        // todo 清掉什么信息？
        public void Close()
        {
        }

        // return:
        //      -1  error
        //      0   dp2Library的版本号过低。警告信息在strError中
        //      1   dp2Library版本号符合要求
        public long GetVersion(out string version,
            out string strError)
        {
            strError = "";
            version = "";
            try
            {
                CookieAwareWebClient client = new CookieAwareWebClient(this._cookies);
                client.Headers["Content-type"] = "application/json; charset=utf-8";

                byte[] data = new byte[0];
                byte[] result = client.UploadData(GetRestfulApiUrl("getversion"),
                        "POST",
                        data);

                string strResult = Encoding.UTF8.GetString(result);
                GetVersionResponse response = Deserialize<GetVersionResponse>(strResult);
                version = response.GetVersionResult.ErrorInfo;
                strError = response.GetVersionResult.ErrorInfo;

                return response.GetVersionResult.Value;
            }
            catch (Exception ex)
            {
                strError = "Exception :" + ex.Message;
                return -1;
            }
        }


        /// <summary>
        /// 登录。
        /// 请参考关于 dp2Library API Login() 的详细说明。
        /// </summary>
        /// <param name="strUserName">用户名</param>
        /// <param name="strPassword">密码</param>
        /// <param name="strParameters">登录参数。这是一个逗号间隔的列表字符串</param>
        /// <param name="strError">返回出错信息</param>
        /// <returns>
        /// <para>-1:   出错</para>
        /// <para>0:    登录未成功</para>
        /// <para>1:    登录成功</para>
        /// </returns>
        public LoginResponse Login(string strUserName,
            string strPassword,
            string strParameters)
        {
            CookieAwareWebClient client = new CookieAwareWebClient(this._cookies);
            client.Headers["Content-type"] = "application/json; charset=utf-8";

            LoginRequest request = new LoginRequest();
            request.strUserName = strUserName;
            request.strPassword = strPassword;
            request.strParameters = strParameters;
            byte[] baData = Encoding.UTF8.GetBytes(Serialize(request));

            byte[] result = client.UploadData(this.GetRestfulApiUrl("login"),
                "POST",
                baData);

            string strResult = Encoding.UTF8.GetString(result);

            LoginResponse response = Deserialize<LoginResponse>(strResult);
            return response;
        }


        public LogoutResponse Logout()
        {

            CookieAwareWebClient client = new CookieAwareWebClient(this._cookies);
            client.Headers["Content-type"] = "application/json; charset=utf-8";

            byte[] data = new byte[0];
            byte[] result = client.UploadData(GetRestfulApiUrl("logout"),
                "POST",
                data);

            string strResult = Encoding.UTF8.GetString(result);

            LogoutResponse response = Deserialize<LogoutResponse>(strResult);

            return response;

        }


        #region 内部函数

        /// <summary>
        /// 拼出接口url地址
        /// </summary>
        /// <param name="strMethod"></param>
        /// <returns></returns>
        private string GetRestfulApiUrl(string strMethod)
        {
            if (string.IsNullOrEmpty(this.Url) == true)
                return strMethod;

            if (this.Url[this.Url.Length - 1] == '/')
                return this.Url + strMethod;

            return this.Url + "/" + strMethod;
        }




        public static T Deserialize<T>(string json)
        {
            T obj = Activator.CreateInstance<T>();
            using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
                obj = (T)serializer.ReadObject(ms);
                return obj;
            }
        }

        public static string Serialize<T>(T obj)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
            using (MemoryStream ms = new MemoryStream())
            {
                serializer.WriteObject(ms, obj);
                return Encoding.UTF8.GetString(ms.ToArray());
            }
        }

        #endregion
    }
}
