using System;
using System.ServiceModel;
using MessageLib;

namespace ServiceLib
{
    [ServiceContract]
    public interface IServiceLib
    {
        [OperationContract]
        string TimerDownloads(string timer);

        [OperationContract]
       void GetData(ref MessageLib.Message message);

        [OperationContract]
        void GetDataDB(ref MessageDB messageDB);

    }

}
