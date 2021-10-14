using System;
using System.Collections.Generic;
using System.ServiceModel;
using MessageLib;
using Npgsql;

namespace ServiceLib
{
    public class ServiceLib : IServiceLib
    {
        public string TimerDownloads(string timer)
        {
            string outputMessage;

            return outputMessage = "Время потраченное на загрузку страницы : " + timer; ;
        }
        public void GetData(ref MessageLib.Message message)
        {
            message.proxy = "127.0.0.1:10000";
            message.name = "AutopoiskService";
        }
        public void GetDataDB(ref MessageDB messageDB)
        {
            string Host = "192.168.1.237";
            string User = "postgres";
            string DBname = "AutopoiskDB";
            string Password = "!QAZxsw2";
            string Port = "5432";

            string connString = String.Format($"Server={Host};Username={User};Database={DBname};Port={Port};Password={Password};SSLMode=Prefer");

            using (var conn = new NpgsqlConnection(connString))
            {
                Log.Instance.Info("Открытие соединения", "Служба");
                conn.Open();
                Log.Instance.Info("Соединение активно", "Служба");

                using (var command = new NpgsqlCommand("SELECT * FROM autopoisktable", conn))
                {
                    var reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        messageDB.id = reader.GetInt64(0).ToString();
                        messageDB.name = reader.GetString(1);
                    }
                }
                conn.Close();
            }

        }

    }
}

