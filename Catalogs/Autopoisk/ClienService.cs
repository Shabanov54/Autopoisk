using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace PortalMazda
{
    class ClienService
    {
        public string ClientServiceRun(string timeTomessage)
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
            string massage = service.TimerDownloads(timeTomessage);
            Log.Instance.Info("Возвращаем строковое значение ", "Клиент");

            return massage;

        }

    }
}
