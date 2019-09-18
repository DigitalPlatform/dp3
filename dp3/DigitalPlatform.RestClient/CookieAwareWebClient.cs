using System;
using System.Net;

namespace DigitalPlatform.RestClient
{
    /// <summary>
    /// 从WebClient继承
    /// </summary>
    public class CookieAwareWebClient : WebClient
    {
        /// 保持通道的恒定身份，是靠 HTTP 通讯的 Cookies 机制
        public CookieContainer CookieContainer { get; set; }

        // 构造时new  CookieContainer
        public CookieAwareWebClient() : this(new CookieContainer())
        { }

        // 构造函数，传入CookieContaner
        public CookieAwareWebClient(CookieContainer c)
        {
            this.CookieContainer = c;
        }

        protected override WebRequest GetWebRequest(Uri address)
        {
            WebRequest request = base.GetWebRequest(address);
            if (request is HttpWebRequest)
            {
                (request as HttpWebRequest).CookieContainer = this.CookieContainer;
            }
            return request;
        }
    }
}
