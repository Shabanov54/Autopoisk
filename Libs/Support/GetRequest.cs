using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PortalMazda
{
    class GetRequest
    {
        private string url;
        public GetRequest(string _url)
        {
            this.url = _url;
        }

        public void Run()
        {

            //HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            //webRequest.Proxy = new WebProxy("127.0.0.1:8888");
            //webRequest.Method = "GET";
            //webRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.2; Win64; x64; Trident/7.0; .NET4.0C; .NET4.0E)";
            //webRequest.Accept = "*/*";
            //webRequest.Headers.Add("Accept-Language","ru,en-US;q=0.7,en;q=0.3");
            //webRequest.Headers.Add("Accept-Encoding" ,"gzip, deflate");
            //ProxyControl.Set("127.0.0.1:8888");
        }
    }
}
