using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserDB
{
    [Table("AutopoiskDB")]
    public class User
    {
        [Column("id")]
        public int id { get; set; }
        [Column("name")]
        public string name { get; set; }
    }
}
