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
        private static string Host = "192.168.1.237";
        private static string User = "postgres";
        private static string DBname = "AutopoiskDB";
        private static string Password = "!QAZxsw2";
        private static string Port = "5432";

        protected override void OnStart(string[] args)
        {
            RunService service = new RunService();
            Log.Instance.Info("Старт серверной части", "Служба");

            Thread startService = new Thread(new ThreadStart(service.Start));
            Log.Instance.Info("Старт подключения к БД", "Служба");

            Thread connectToDB = new Thread(new ThreadStart(service.RunConn));

            service.Start();
            service.RunConn();
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
            public void RunConn()
            {
                string connString = String.Format($"Server={Host};Username={User};Database={DBname};Port={Port};Password={Password};SSLMode=Prefer");
                var conn = new NpgsqlConnection(connString);
                Log.Instance.Info("Открытие соединения", "Служба");
                conn.Open();
                Log.Instance.Info("Соединение активно", "Служба");

            }
        }
    }
}
