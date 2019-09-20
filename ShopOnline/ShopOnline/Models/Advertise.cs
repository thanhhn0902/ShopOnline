using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopOnline.Models
{
    [Table("ADVERTISE")]
    public class Advertise
    {
        [Key]
        public int Id { get; set; }
        [StringLength(500)]
        public string Name { get; set; }
        [StringLength(500)]
        public string Url { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        [StringLength(500)]
        public string Link { get; set; }
        public int Target { get; set; }
        public int Position { get; set; }
        //[]
        public int Order { get; set; }
        public int Status { get; set; }

    }
}