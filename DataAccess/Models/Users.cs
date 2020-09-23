using System;
using System.Collections.Generic;
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
        [StringLength(100)]
        public string Old { get; set; }
    }
}
