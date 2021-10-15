using System;
using UserDB;
using System.Linq;
using System.Collections.Generic;

namespace AutopoiskEFCore
{
    class GetDB
    {
        static void Main(string[] args)
        {
            //List<User> user = new List<User>();
            using (var db = new Context())
            {
                if (db.Database.CanConnect())
                {
                    var users = db.autopoisktable.ToList();
                    Console.WriteLine("Получение обектов из бд");
                    foreach (var user in users)
                    {
                        Console.WriteLine($"{user.id}  -  {user.name}");
                    }
                }
                else
                {
                    Console.WriteLine("Нет подключения к бд");
                }
            }
        }
    }
}
