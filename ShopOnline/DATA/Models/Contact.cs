using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DATA.Models
{
    [Table("CONTACT")]
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [StringLength(500)]
        public string Name { get; set; }
        [StringLength(500)]
        public string Company { get; set; }
        //ntext
        [MaxLength, Column(TypeName = "ntext")]
        public string Address { get; set; }
        [StringLength(20)]
        public string Tel { get; set; }
        [StringLength(20)]
        public string Mal { get; set; }
        //ntext
        [MaxLength, Column(TypeName = "ntext")]
        public string Detail { get; set; }
        public DateTime Date { get; set; }
    }
}