using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SW.Model.Models
{
    [Table("OrdersDetails")]
    public class OrdersDetail
    {
        [Key]
        [Column(Order=1)]
        public int OrderID { get; set; }
        [ForeignKey("OrderID")]
        public virtual Order Order { get; set; }
        [Key]
        [Column(Order = 2)]
        public int ProductID { get; set; }
        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal Pride { get; set; }
    }
}