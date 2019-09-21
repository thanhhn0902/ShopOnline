using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DATA.Models
{
    [Table("SUPPORT")]
    public class Support
    {
        [Key]
        public int Id { get; set; }
        [StringLength(500)]
        public string Name { get; set; }
        [StringLength(20)]
        public string Tel { get; set; }
        public int Type { get; set; }
        [StringLength(500)]
        public string Nick { get; set; }
        //[]
        public int Order { get; set; }
        //[]
        public int Status { get; set; }
    }
}