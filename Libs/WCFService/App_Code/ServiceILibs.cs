using System;
using System.ServiceModel;

namespace Services
{
    [ServiceContract]
    public interface ServiceILibs
    {
        [OperationContract]
        string TimerDownloads(string timer);
    }
}
