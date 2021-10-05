using System;
using System.ServiceModel;

namespace Services
{
    public class ServiceClient
    {
        public void ServiceClient1()
        {
            var serviceAddress = "127.0.0.1:10000";
            var serviceName = "MyService";

            Uri tcpUri = new Uri($"net.tcp://{serviceAddress}/{serviceName}");
            EndpointAddress address = new EndpointAddress(tcpUri);
            NetTcpBinding clientBinding = new NetTcpBinding();
            ChannelFactory<ServiceILibs> factory = new ChannelFactory<ServiceILibs>(clientBinding, address);
            var service = factory.CreateChannel();
        }
    }
}
