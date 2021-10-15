using System;
using System.ComponentModel.DataAnnotations;

namespace UserDB
{
    public class User
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
    }
}
