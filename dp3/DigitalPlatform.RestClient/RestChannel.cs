using System;
using System.Collections.Generic;
using System.Net;
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


        public void Close()
        {
        }
    }
}
