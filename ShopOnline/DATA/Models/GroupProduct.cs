using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DATA.Models
{
    [Table("GROUPPRODUCT")]
    public class GroupProduct
    {
        [Key]
        public int Id { get; set; }
        [StringLength(500)]
        public string Name { get; set; }
        //[]
        [StringLength(500)]
        public string Content { get; set; }
        [StringLength(500)]
        public string Images { get; set; }
        //[]
        public int Order { get; set; }
        public int Status { get; set; }
    }
}