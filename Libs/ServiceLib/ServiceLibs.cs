using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace ServiceLib
{
    public class ServiceLib : IServiceLib
    {
        public string TimerDownloads(string timer)
        {
            string outputMessage;

            return outputMessage = "Время потраченное на загрузку страницы : " + timer; ;
        }
        public void GetData(ref MessageLib.Message message)
        {
            message.proxy = "127.0.0.1:10000";
            message.name = "AutopoiskService";
        }
    }
}
