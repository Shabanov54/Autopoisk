using System;
using UserDB;
using System.Linq;

namespace AutopoiskEFCore
{
    class GetDB
    {
        static void Main(string[] args)
        {
            using (var db = new Context())
            {
                if (db.Database.CanConnect())
                {
                    var users = db.users.ToList();
                    Console.WriteLine("Получение обектов из бд");
                    foreach (var user in users)
                    {
                        Console.WriteLine($"{user.id}  -  {user.name}");
                    }
                }
                else
                {
                    Console.WriteLine("Нет подключения к базе");
                }
            }
        }
    }
}
