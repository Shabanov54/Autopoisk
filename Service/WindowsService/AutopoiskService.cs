using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace WindowsService
{
    public partial class AutopoiskService : ServiceBase
    {
        ServerService server;
        public AutopoiskService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Log.Instance.Info("Started", "Служба");
            server = new ServerService();
            Thread serverService = new Thread(new ThreadStart(server.Start));
            serverService.Start();
        }

        protected override void OnStop()
        {
            Log.Instance.Info("Stop", "Служба");

        }
        public class ServerService
        {

            public void Start()
            {
                var serviceAddress = "127.0.0.1:10000";
                var serviceName = "AutopoiskService";

                var host = new ServiceHost(typeof(ServiceLib.ServiceLib), new Uri($"net.tcp://{serviceAddress}/{serviceName}"));
                var serverBinding = new NetTcpBinding();
                host.AddServiceEndpoint(typeof(ServiceLib.IServiceLib), serverBinding, "");
                host.Open();
                Log.Instance.Info("Серверная часть в работе", "Служба");

                MessageLib.Message message = new MessageLib.Message();
                message.name = serviceName;
                message.proxy = serviceAddress;
            }
        }
    }
}
