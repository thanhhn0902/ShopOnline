using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopOnline.Models
{
    [Table("PROVINCE")]
    public class Province
    {
        [Key]
        public int Id { get; set; }
        [StringLength(500)]
        public string Name { get; set; }
    }
}