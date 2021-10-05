using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

public class ServiceLibs : ServiceILibs
{
    public string TimerDownloads(string timer)
    {
        string outputMessage;

        return outputMessage = "Время потраченное на загрузку страницы : " + timer; ;
    }
}
