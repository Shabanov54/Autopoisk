using System;
using System.ServiceModel;

    namespace WcfService
{
    [ServiceContract]

    public interface IServiceLibs
    {
        [OperationContract]
        string TimerDownloads(string timer);
    }
}
