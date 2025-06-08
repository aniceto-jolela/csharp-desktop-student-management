using System.ComponentModel.DataAnnotations;

namespace cpqi.Models
{
    public class Role
    {
        [Key]
        public int RoleID { get; set; }

        [Required]
        [MaxLength(25)]
        public required string RoleName { get; set; }

        [MaxLength(50)]
        public string? Description { get; set; }
    }
}
