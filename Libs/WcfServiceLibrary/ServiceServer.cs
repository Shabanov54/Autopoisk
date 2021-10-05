using System;
using System.ServiceModel;
using WcfService;

public class ServiceServer
{
    public void CreateServiceServer()
    {
        var serviceAddress = "127.0.0.1:10000";
        var serviceName = "MyService";

        var host = new ServiceHost(typeof(IServiceLibs), new Uri($"net.tcp://{serviceAddress}/{serviceName}"));
        var serverBinding = new NetTcpBinding();
        host.AddServiceEndpoint(typeof(IServiceLibs), serverBinding, "");
        host.Open();
    }
}
