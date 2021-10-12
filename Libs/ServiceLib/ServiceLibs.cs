using System;

namespace ServiceLib
{
    public class ServiceLib : IServiceLib
    {
        public string TimerDownloads(string timer)
        {
            string outputMessage;

            return outputMessage = "Время потраченное на загрузку страницы : " + timer; ;
        }
        public string GetData(MessageLib.Message message)
        {
            string getDatamessage;
            return getDatamessage = $"{message.name} \n {message.proxy}";
        }
    }
}
