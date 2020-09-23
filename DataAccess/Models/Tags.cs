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
        [StringLength(20)]
        public string TagId { set; get; }
        [Column(TypeName = "ntext")]
        public string Content { set; get; }
    }
}
