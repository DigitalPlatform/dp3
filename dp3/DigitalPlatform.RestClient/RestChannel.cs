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

        // 重登录次数
        int _loginCount = 0;

        /// <summary>
        /// 按需登录
        /// </summary>
        public event BeforeLoginEventHandle BeforeLogin;

        // 关闭通道
        public void Close()
        {
            // 调logout接口
            this.Logout();
        }

        /*
         返回值：
        LibraryServerResult.Value	0	成功
        LibraryServerResult.ErrorInfo		版本号字符串。例如”2.1”
        权限：不需要特定的权限。
        本API不需要先行登录即可使用。        
         */
        public GetVersionResponse GetVersion()
        {
            CookieAwareWebClient client = new CookieAwareWebClient(this._cookies);
            client.Headers["Content-type"] = "application/json; charset=utf-8";

            byte[] data = new byte[0];
            byte[] result = client.UploadData(GetRestfulApiUrl("getversion"),
                    "POST",
                    data);
            string strResult = Encoding.UTF8.GetString(result);
            GetVersionResponse response = Deserialize<GetVersionResponse>(strResult);
            return response;
        }


 

        /// <summary>
        /// 登录。
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


        /// <summary>
        /// 登出
        /// </summary>
        /// <returns></returns>
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


        /// <summary>
        /// 处理登录事宜
        /// </summary>
        /// <param name="strError">返回出错信息</param>
        /// <returns>-1: 出错; 1: 登录成功</returns>
        public int DoNotLogin(out string strError)
        {
            strError = "";
            if (this.BeforeLogin == null)
            {
                strError = "未挂接按需登录事件";
                return -1;
            }

            BeforeLoginEventArgs e = new BeforeLoginEventArgs();
            e.LibraryServerUrl = this.Url; //???
            e.FirstTry = true;
            e.ErrorInfo = strError;

        REDOLOGIN:
            this.BeforeLogin(this, e); //调事件

            if (e.Cancel == true)
            {
                if (String.IsNullOrEmpty(e.ErrorInfo) == true)
                    strError = "用户放弃登录";
                else
                    strError = e.ErrorInfo;
                return -1;
            }

            if (e.Failed == true)
            {
                strError = e.ErrorInfo;
                return -1;
            }

            if (this.Url != e.LibraryServerUrl)
            {
                this.Close();  
                this.Url = e.LibraryServerUrl;
            }

            string strMessage = "";
            if (e.FirstTry == true)
                strMessage = strError;

            if (_loginCount > 100)
            {
                strError = "重新登录次数太多，超过 100 次，请检查登录 API 是否出现了逻辑问题";
                _loginCount = 0;    // 重新开始计算
                return -1;
            }
            _loginCount++;

            LoginResponse response = this.Login(e.UserName,
                e.Password,
                e.Parameters);
            if (response.LoginResult.Value == -1 || response.LoginResult.Value == 0)
            {
                if (String.IsNullOrEmpty(strMessage) == false)
                    e.ErrorInfo = strMessage + "\r\n\r\n首次自动登录报错: ";
                else
                    e.ErrorInfo = "";
                e.ErrorInfo += strError;
                e.FirstTry = false;
                e.LoginFailCondition = LoginFailCondition.PasswordError;
                goto REDOLOGIN;
            }

            return 1;   // 登录成功,可以重调API功能了
        }

        // 2011/1/21
        // 预约
        // parameters:
        //      strItemBarcodeList  册条码号列表，逗号间隔
        // 权限：需要有reservation权限
        public ReservationResponse Reservation(string action,
            string strReaderBarcode,
            string strItemBarcodeList)
        {
            string strError = "";

        REDO:

            CookieAwareWebClient client = new CookieAwareWebClient(this._cookies);
            client.Headers["Content-type"] = "application/json; charset=utf-8";

            ReservationRequest request = new ReservationRequest();
            request.strFunction = action;
            request.strReaderBarcode = strReaderBarcode;
            request.strItemBarcodeList = strItemBarcodeList;

            byte[] baData = Encoding.UTF8.GetBytes(Serialize(request));
            string strRequest = Encoding.UTF8.GetString(baData);
            byte[] result = client.UploadData(this.GetRestfulApiUrl("Reservation"),
                            "POST",
                             baData);

            string strResult = Encoding.UTF8.GetString(result);
            ReservationResponse response = Deserialize<ReservationResponse>(strResult);
            // 未登录时，按需登录
            if (response.ReservationResult.Value == -1
                && response.ReservationResult.ErrorCode == ErrorCode.NotLogin)
            {
                if (DoNotLogin(out strError) == 1)
                    goto REDO;

                // 把按需登录的错误信息包括进去
                if (string.IsNullOrEmpty(strError) == false)
                {
                    response.ReservationResult.ErrorInfo += "\r\n" + strError;
                }
            }

            return response;
        }

        // 检索书目
        public SearchBiblioResponse SearchBiblio(string strBiblioDbNames,
            string strQueryWord,
            int nPerMax,
            string strFromStyle,
            string strMatchStyle,
            string strResultSetName,
            string strOutputStyle)
        {

        REDO:

            CookieAwareWebClient client = new CookieAwareWebClient(this._cookies);
            client.Headers["Content-type"] = "application/json; charset=utf-8";

            SearchBiblioRequest request = new SearchBiblioRequest();
            request.strBiblioDbNames = strBiblioDbNames;
            request.strQueryWord = strQueryWord;
            request.nPerMax = nPerMax;
            request.strFromStyle = strFromStyle;
            request.strMatchStyle = strMatchStyle;
            request.strLang = "zh";
            request.strResultSetName = strResultSetName;
            request.strSearchStyle = "";// "desc";
            request.strOutputStyle = strOutputStyle;

            byte[] baData = Encoding.UTF8.GetBytes(Serialize(request));
            string strRequest = Encoding.UTF8.GetString(baData);
            byte[] result = client.UploadData(this.GetRestfulApiUrl("SearchBiblio"),
                            "POST",
                             baData);

            string strResult = Encoding.UTF8.GetString(result);
            SearchBiblioResponse response = Deserialize<SearchBiblioResponse>(strResult);
            // 未登录时，按需登录
            if (response.SearchBiblioResult.Value == -1
                && response.SearchBiblioResult.ErrorCode == ErrorCode.NotLogin)
            {
                string strError = "";
                if (DoNotLogin(out strError) == 1)
                    goto REDO;

                // 把按需登录的错误信息包括进去
                if (string.IsNullOrEmpty(strError) == false)
                {
                    response.SearchBiblioResult.ErrorInfo += "\r\n" + strError;
                }
            }

            return response;
        }



        /// <summary>
        /// 获得检索结果。
        /// </summary>
        /// <param name="strResultSetName">结果集名。如果为空，表示使用当前缺省结果集"default"</param>
        /// <param name="lStart"> 要获取的开始位置。从0开始计数</param>
        /// <param name="lCount">要获取的个数</param>
        /// <param name="strBrowseInfoStyle">返回信息的方式。
        /// id / cols / xml / timestamp / metadata / keycount / keyid 的组合。keycount 和 keyid 二者只能使用一个，缺省为 keyid。
        /// 还可以组合使用 format:???? 这样的子串，表示使用特定的浏览列格式
        /// </param>
        public GetSearchResultResponse GetSearchResult(
            string strResultSetName,
            long lStart,
            long lCount,
            string strBrowseInfoStyle)
        {
        REDO:

            CookieAwareWebClient client = new CookieAwareWebClient(this._cookies);
            client.Headers["Content-type"] = "application/json; charset=utf-8";

            GetSearchResultRequest request = new GetSearchResultRequest();
            request.strResultSetName = strResultSetName;
            request.lStart = lStart;
            request.lCount = lCount;
            request.strBrowseInfoStyle = strBrowseInfoStyle;
            request.strLang = "zh";//strLang;

            byte[] baData = Encoding.UTF8.GetBytes(Serialize(request));
            byte[] result = client.UploadData(this.GetRestfulApiUrl("getsearchresult"),
                                                "POST",
                                                baData);

            string strResult = Encoding.UTF8.GetString(result);
            GetSearchResultResponse response = Deserialize<GetSearchResultResponse>(strResult);

            // 未登录时，按需登录
            if (response.GetSearchResultResult.Value == -1
                && response.GetSearchResultResult.ErrorCode == ErrorCode.NotLogin)
            {
                string strError = "";
                if (DoNotLogin(out strError) == 1)
                    goto REDO;

                // 把按需登录的错误信息包括进去
                if (string.IsNullOrEmpty(strError) == false)
                {
                    response.GetSearchResultResult.ErrorInfo += "\r\n" + strError;
                }
            }

            return response;
        }


        public GetBiblioInfoResponse GetBiblioInfo(
            string strBiblioRecPath,
            string strBiblioType)
        {
        REDO:

            CookieAwareWebClient client = new CookieAwareWebClient(this._cookies);
            client.Headers["Content-type"] = "application/json; charset=utf-8";

            GetBiblioInfoRequest request = new GetBiblioInfoRequest();
            request.strBiblioRecPath = strBiblioRecPath;
            request.strBiblioType = strBiblioType;
            request.strBiblioXml = "";

            byte[] baData = Encoding.UTF8.GetBytes(Serialize(request));
            byte[] result = client.UploadData(this.GetRestfulApiUrl("GetBiblioInfo"),
                                                "POST",
                                                baData);

            string strResult = Encoding.UTF8.GetString(result);
            GetBiblioInfoResponse response = Deserialize<GetBiblioInfoResponse>(strResult);

            // 未登录时，按需登录
            if (response.GetBiblioInfoResult.Value == -1
                && response.GetBiblioInfoResult.ErrorCode == ErrorCode.NotLogin)
            {
                string strError = "";
                if (DoNotLogin(out strError) == 1)
                    goto REDO;

                // 把按需登录的错误信息包括进去
                if (string.IsNullOrEmpty(strError) == false)
                {
                    response.GetBiblioInfoResult.ErrorInfo += "\r\n" + strError;
                }
            }

            return response;
        }

        #region exception

        /// <summary>
        /// 获得异常信息
        /// </summary>
        /// <param name="ex">异常对象</param>
        /// <returns></returns>
        public static string GetExceptionMessage(Exception ex)
        {
            string strResult = ex.GetType().ToString() + ":" + ex.Message;
            while (ex != null)
            {
                if (ex.InnerException != null)
                    strResult += "\r\n" + ex.InnerException.GetType().ToString() + ": " + ex.InnerException.Message;

                ex = ex.InnerException;
            }

            return strResult;
        }

        #endregion

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


    /// <summary>
    /// 登录前的事件
    /// </summary>
    /// <param name="sender">发送者</param>
    /// <param name="e">事件参数</param>
    public delegate void BeforeLoginEventHandle(object sender,BeforeLoginEventArgs e);

    /// <summary>
    /// 登录前时间的参数
    /// </summary>
    public class BeforeLoginEventArgs : EventArgs
    {
        /// <summary>
        /// [in] 是否为第一次触发
        /// </summary>
        public bool FirstTry = true;    // [in] 是否为第一次触发
        /// <summary>
        /// [in] 图书馆应用服务器 URL
        /// </summary>
        public string LibraryServerUrl = "";    // [in] 图书馆应用服务器URL

        /// <summary>
        /// [out] 用户名
        /// </summary>
        public string UserName = "";    // [out] 用户名
        /// <summary>
        /// [out] 密码
        /// </summary>
        public string Password = "";    // [out] 密码
        /// <summary>
        /// [out] 工作台号
        /// </summary>
        public string Parameters = "";    // [out] 工作台号

        /// <summary>
        /// [out] 事件调用是否失败
        /// </summary>
        public bool Failed = false; // [out] 事件调用是否失败
        /// <summary>
        /// [out] 事件调用是否被放弃
        /// </summary>
        public bool Cancel = false; // [out] 事件调用是否被放弃

        /// <summary>
        /// [in, out] 事件调用错误信息
        /// </summary>
        public string ErrorInfo = "";   // [in, out] 事件调用错误信息

        /// <summary>
        /// [in, out] 前次登录失败的原因，本次登录失败的原因
        /// </summary>
        public LoginFailCondition LoginFailCondition = LoginFailCondition.NormalError;
    }

    /// <summary>
    /// 登录失败的原因
    /// </summary>
    public enum LoginFailCondition
    {
        /// <summary>
        /// 没有出错
        /// </summary>
        None = 0,   // 没有出错
        /// <summary>
        /// 一般错误
        /// </summary>
        NormalError = 1,    // 一般错误
        /// <summary>
        /// 密码不正确
        /// </summary>
        PasswordError = 2,  // 密码不正确
    }
}
