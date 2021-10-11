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
        public void ClientServiceRun(string timeTomessage)
        {
            var serviceAddress = "127.0.0.1:10000";
            var serviceName = "AutopoiskService";

            Uri tcpUri = new Uri($"net.tcp://{serviceAddress}/{serviceName}");
            EndpointAddress address = new EndpointAddress(tcpUri);
            NetTcpBinding clientBinding = new NetTcpBinding();
            ChannelFactory<ServiceLibs.IServiceLib> factory = new ChannelFactory<ServiceLibs.IServiceLib>(clientBinding, address);
            var service = factory.CreateChannel();

            string massage = service.TimerDownloads(timeTomessage);
        }

    }
}
