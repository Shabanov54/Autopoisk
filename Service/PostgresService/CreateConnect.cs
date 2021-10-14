using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace PostgresCreateConnService
{
    public partial class CreateConnect : ServiceBase
    {
        public CreateConnect()
        {

            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            RunService service = new RunService();
            Thread connectToDB = new Thread(new ThreadStart(service.Start));
            Log.Instance.Info("Started", "Служба");
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

            }
        }
    }
}
