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
            StartService();
        }

        private static void StartService()
        {
            ServiceController service = new ServiceController();
            service.ServiceName = "AutopoiskService2";
            service.Start();
        }

        public void onDebug()
        {
            OnStart(null);
        }
        protected override void OnStart(string[] args)
        {
            server = new ServerService();
            Thread serverService = new Thread(new ThreadStart(server.Start));
            serverService.Start();
        }

        protected override void OnStop()
        {
            server.Stop();
        }
        class ServerService
        {
            public void Start()
            {
                var serviceAddress = "127.0.0.1:10000";
                var serviceName = "AutopoiskService2";

                var host = new ServiceHost(typeof(ServiceLib.ServiceLib), new Uri($"net.tcp://{serviceAddress}/{serviceName}"));
                var serverBinding = new NetTcpBinding();
                host.AddServiceEndpoint(typeof(ServiceLib.IServiceLib), serverBinding, "");
                host.Open();
            }
            public void Stop()
            {

            }
        }
    }
}
