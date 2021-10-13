using System;
using System.ServiceModel;

namespace ServiceLib
{
    [ServiceContract]
    public interface IServiceLib
    {
        [OperationContract]
        string TimerDownloads(string timer);
        [OperationContract]
        MessageLib.Message GetData(MessageLib.Message message);
    }
}
