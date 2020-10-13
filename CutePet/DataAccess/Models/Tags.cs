using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models
{
    [Table("Tags")]
    public class Tags
    {
        [Key]
        public int TagId { set; get; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Column(TypeName = "ntext")]
        public string Content { set; get; }
        [ForeignKey("UserId")]
        public virtual Users usr { get; set; }
        public virtual Products pror { get; set; }
        public virtual Orders ordr { get; set; }
    }
}
