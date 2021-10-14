using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PostgresServise
{
    
    public static class ConnectDB
    {
        private static string Host = "192.168.1.237";
        private static string User = "postgres";
        private static string DBname = "Autopoisk";
        private static string Password = "!QAZxsw2";
        private static string Port = "5432";
        public static NpgsqlConnection conn;
        public static void ConnectionDB()
        {
            string connString = String.Format($"Server={0};Username={1};Database={2};Port={3};Password={4};SSLMode=Prefer",
        Host,
        User,
        DBname,
        Port,
        Password);
            using (conn = new NpgsqlConnection(connString))
            {
                Log.Instance.Info("Открытие соединения", "Служба");
                conn.Open();
            }

        }
    }
}
