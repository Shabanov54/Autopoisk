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
            using (var command = new NpgsqlCommand("SELECT * FROM autopoisktable"))
            {
                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    messageDB.id = reader.GetInt64(0).ToString();
                    messageDB.name = reader.GetString(1);
                }
            }
        }
    }
}

