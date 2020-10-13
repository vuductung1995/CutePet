using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccess.Models
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        public int TagId { set; get; }
        [StringLength(200)]
        [Required]
        public string Adress { get; set; }
        [Required]
        public DateTime DateOrder { get; set; }

    }
}
