using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageLib;
using Npgsql;

namespace PostgresServise
{
    public class ReadDB
    {
        public static void GetData()
        {
            using (var comand = new NpgsqlCommand("SELECT * FROM autopoisktable;", ConnectDB.conn))
            {
                var reader = comand.ExecuteReader();
                MessageDB messageDB = new MessageDB();
                messageDB.id = reader.GetInt64(0);
                messageDB.name = reader.GetString(1);
            }

        }
    }
}
