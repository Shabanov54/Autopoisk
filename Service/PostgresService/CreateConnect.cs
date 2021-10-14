using Npgsql;
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
        private static string Host = "192.168.1.237";
        private static string User = "postgres";
        private static string DBname = "Autopoisk";
        private static string Password = "!QAZxsw2";
        private static string Port = "5432";
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
                string connString = String.Format($"Server={0};Username={1};Database={2};Port={3};Password={4};SSLMode=Prefer",
            Host,
            User,
            DBname,
            Port,
            Password);
                var conn = new NpgsqlConnection(connString);
                Log.Instance.Info("Открытие соединения", "Служба");
                conn.Open();
            }
        }
    }
}
