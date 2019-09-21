using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DATA.Models
{
    [Table("CUSTOMERS")]
    public class Customers
    {
        [Key]
        public int Id { get; set; }
        [StringLength(500)]
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        [StringLength(500)]
        public string Province { get; set; }
        //ntext
        [MaxLength, Column(TypeName = "ntext")]
        public string Address { get; set; }
        [StringLength(20)]
        public string Tel { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
    }
}