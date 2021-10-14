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
        private static string Host = "mydemoserver.postgres.database.azure.com";
        private static string User = "mylogin@mydemoserver";
        private static string DBname = "mypgsqldb";
        private static string Password = "<server_admin_password>";
        private static string Port = "5432";
        public CreateConnect()
        {

            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            RunService service = new RunService();
            Thread connectToDB = new Thread(new ThreadStart(service.Start));
            service.Start();
        }

        protected override void OnStop()
        {
        }
        public class RunService
        {
            public void Start()
            {

            }
        }
    }
}
