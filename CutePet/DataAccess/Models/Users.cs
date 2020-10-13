using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int UserId { set; get; }
        [StringLength(100)]
        public string Name { set; get; }
        public int Old { get; set; }
        [StringLength(200)]
        public string Adress { get; set; }

    }
}
