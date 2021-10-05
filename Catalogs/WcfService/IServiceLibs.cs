using System;
using System.ServiceModel;

    [ServiceContract]
    public interface ServiceILibs
    {
        [OperationContract]
        string TimerDownloads(string timer);
    }
