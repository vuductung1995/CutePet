using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccess.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public int TagId { set; get; }
        [StringLength(200)]
        public string ProductName { get; set; }
        [StringLength(300)]
        public string Decription { get; set; }
        [Required]
        public double Price { get; set; }

    }
}
