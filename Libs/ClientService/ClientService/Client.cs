using System;
using System.ServiceModel;

namespace ClientService
{
    public static class Client
    {
        public static string RunClient(string timeTomessage)
        {
            var serviceAddress = "127.0.0.1:10000";
            var serviceName = "AutopoiskService";

            Uri tcpUri = new Uri($"net.tcp://{serviceAddress}/{serviceName}");
            EndpointAddress address = new EndpointAddress(tcpUri);
            NetTcpBinding clientBinding = new NetTcpBinding();
            ChannelFactory<ServiceLib.IServiceLib> factory = new ChannelFactory<ServiceLib.IServiceLib>(clientBinding, address);
            var service = factory.CreateChannel();
            Log.Instance.Info("Запуск клиентской части приложения", "Клиент");
            Log.Instance.Info("Передаем строковое значение в клиентскую часть, для обработки", "Клиент");
            string massageOut = service.TimerDownloads(timeTomessage);

            //MessageLib.Message message = new MessageLib.Message();
            //message = service.GetData(message);


            Log.Instance.Info("Возвращаем строковое значение ", "Клиент");
            return massageOut;
        }
        public static string RunGetData()
        {
            var serviceAddress = "127.0.0.1:10000";
            var serviceName = "AutopoiskService";

            Uri tcpUri = new Uri($"net.tcp://{serviceAddress}/{serviceName}");
            EndpointAddress address = new EndpointAddress(tcpUri);
            NetTcpBinding clientBinding = new NetTcpBinding();
            ChannelFactory<ServiceLib.IServiceLib> factory = new ChannelFactory<ServiceLib.IServiceLib>(clientBinding, address);
            var service = factory.CreateChannel();

            MessageLib.Message message = new MessageLib.Message();
            message = service.GetData(message);
            string messageGetData = $"{message.name}\n{message.proxy}";

            return messageGetData;
        }

    }
}
