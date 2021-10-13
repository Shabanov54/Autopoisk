using System;
using System.ServiceModel;

namespace ServiceLib
{
    [ServiceContract]
    public interface IServiceLib
    {
        [OperationContract]
        string TimerDownloads(string timer);
        [OperationContract(IsOneWay =true)]
        void GetData(MessageLib.Message message);
    }
}
