using System;
using System.ComponentModel.DataAnnotations;

namespace UserDB
{
    public class User
    {
        [Key]
        public long id { get; set; }
        public string name { get; set; }
    }
}
