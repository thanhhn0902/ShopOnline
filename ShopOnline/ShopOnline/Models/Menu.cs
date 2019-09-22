using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopOnline.Models
{
    [Table("MENU")]
    public class Menu
    {
        [Key]
        public int Id { get; set; }
        [StringLength(500)]
        public string Name { get; set; }
        [StringLength(500)]
        public string Link { get; set; }
        //[]
        public int Order { get; set; }
        public int Parent_Id { get; set; }
    }
}