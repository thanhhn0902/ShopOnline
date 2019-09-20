using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopOnline.Models
{
    [Table("ORDER")]
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int Customer_Id { get; set; }
        public float TotalMoney { get; set; }
        public DateTime Date { get; set; }
        public int Status { get; set; }
    }
}