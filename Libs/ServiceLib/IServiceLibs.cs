using System;
using System.ServiceModel;

namespace ServiceLibs
{
    [ServiceContract]
    public interface IServiceLib
    {
        [OperationContract]
        string TimerDownloads(string timer);
    }
}
