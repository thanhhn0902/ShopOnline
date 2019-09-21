using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DATA.Models
{
    [Table("USERS")]
    public class Users
    {
        [Key]
        public int Id { get; set; }
        [StringLength(500)]
        public string Name { get; set; }
        [StringLength(255)]
        [Required(ErrorMessage = "Xin hãy nhập vào UserName!!!")]
        public string UserName { get; set; }
        [StringLength(255)]
        [Required(ErrorMessage = "Xin hãy nhập vào Password!!!")]
        public string Password { get; set; }
        public int Rule { get; set; }
        public int Status { get; set; }
    }
}