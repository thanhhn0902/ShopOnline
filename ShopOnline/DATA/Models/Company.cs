using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DATA.Models
{
    [Table("COMPANY")]
    public class Company
    {
        [Key]
        public int Id { get; set; }
        [StringLength(500)]
        public string Name { get; set; }
        //ntext
        [MaxLength, Column(TypeName = "ntext")]
        public string Address { get; set; }
        [StringLength(20)]
        public string PhoneNumber { get; set; }
        [StringLength(20)]
        public string Fax { get; set; }
    }
}