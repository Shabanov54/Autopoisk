using System;
using System.ServiceModel;

namespace ServiceLibs
{
    [ServiceContract]
    public interface ServiceILibs
    {
        [OperationContract]
        string TimerDownloads(string timer);
    }
}
