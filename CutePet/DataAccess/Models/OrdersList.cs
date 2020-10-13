using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccess.Models
{
    public class OrdersList
    {
        [Key]
        public int OrdersListId { get; set; }
        public virtual Orders ordr { get; set; }
        public virtual Products pror { get; set; }
    }
}
