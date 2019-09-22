using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopOnline.Models
{
    [Table("PRODUCT")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [StringLength(500)]
        public string Name { get; set; }
        //ntext
        [MaxLength, Column(TypeName = "ntext")]
        public string Detail { get; set; }
        public float Price { get; set; }
        [StringLength(500)]
        public string Image { get; set; }
        public float PriceNew { get; set; }
        public DateTime Date { get; set; }
        public int Order { get; set; }
        public int Status { get; set; }
        public int GroupProduct_Id { get; set; }

    }
}