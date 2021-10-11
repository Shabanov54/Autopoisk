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
using System.Threading.Tasks;

namespace WindowsService
{
    public partial class AutopoiskService : ServiceBase
    {
        public AutopoiskService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }
        class ServerService
        {
            bool enable = true;
            public ServerService()
            {

            }
            public void Start()
            {
                var serviceAddress = "127.0.0.1:10000";
                var serviceName = "AutopoiskService";

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
