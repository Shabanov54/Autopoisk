using Microsoft.EntityFrameworkCore;
using System;
using UserDB;

namespace AutopoiskEFCore
{
    public class Context :DbContext
    {
        string Host = "192.168.1.237";
        string User = "postgres";
        string DBname = "AutopoiskDB";
        string Password = "!QAZxsw2";
        string Port = "5432";
        public DbSet<User> autopoisktable { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql($"Server={Host};Username={User};Database={DBname};Password ={Password}; Port ={Port}");
        }
    }
}
