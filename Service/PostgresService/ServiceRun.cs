using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Npgsql;
using ServiceLib;


namespace PostgresService
{
    public partial class ServiceRun : ServiceBase
    {

        protected override void OnStart(string[] args)
        {
            RunService service = new RunService();
            Log.Instance.Info("Старт серверной части", "Служба");

            Thread startService = new Thread(new ThreadStart(service.Start));
            service.Start();
        }

        protected override void OnStop()
        {
            Log.Instance.Info("Stoped", "Служба");
        }
        public class RunService
        {
            public void Start()
            {
                var serviceAddress = "127.0.0.1:5000";
                var serviceName = "PostgresService";
                Log.Instance.Info("Запуск серверной части", "Служба");

                var host = new ServiceHost(typeof(ServiceLib.ServiceLib), new Uri($"net.tcp://{serviceAddress}/{serviceName}"));
                var serverBinding = new NetTcpBinding();
                host.AddServiceEndpoint(typeof(IServiceLib), serverBinding, "");
                host.Open();
                Log.Instance.Info("Серверная часть в работе", "Служба");

            }
        }
    }
}
