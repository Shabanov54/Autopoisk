using System;
using System.ServiceModel;



    public class ServiceServer
    {
        public void CreateServiceServer()
        {
            var serviceAddress = "127.0.0.1:10000";
            var serviceName = "MyService";

            var host = new ServiceHost(typeof(ServiceLibs), new Uri($"net.tcp://{serviceAddress}/{serviceName}"));
            var serverBinding = new NetTcpBinding();
            host.AddServiceEndpoint(typeof(ServiceILibs), serverBinding, "");
            host.Open();
        }
    }
