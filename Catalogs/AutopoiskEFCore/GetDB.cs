using System;
using UserDB;
using System.Linq;

namespace AutopoiskEFCore
{
    class GetDB
    {
        static void Main(string[] args)
        {
            User user = new User();
            using (var db = new Context())
            {
                if (db.Database.CanConnect())
                {
                    var users = db.users;
                    Console.WriteLine("Получение обектов из бд");
                    Console.WriteLine($"{user.id}  -  {user.name}");
                }
                else
                {
                    Console.WriteLine("Нет подключения к базе");
                }
            }
        }
    }
}
