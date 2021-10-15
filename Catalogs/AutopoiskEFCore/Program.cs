using System;
using UserDB;
using AppContext;
using System.Linq;

namespace AutopoiskEFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Context())
            {
                var users = db.users.ToList();
                Console.WriteLine("Получение обектов из бд");
                foreach (var user in users)
                {
                    Console.WriteLine($"{user.id}  -  {user.name}");
                }
            }
        }
    }
}
