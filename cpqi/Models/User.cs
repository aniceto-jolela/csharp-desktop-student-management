using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpqi.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        [MaxLength(50)]
        public required string UserName { get; set; }

        [Required]
        [MaxLength(100)]
        public required string FullName { get; set; }

        [Required]
        [MaxLength(10)]
        public required string Sex { get; set; }

        [EmailAddress]
        [MaxLength(100)]
        public string? Email { get; set; }

        [Phone]
        [MaxLength(20)]
        public string? Phone { get; set; }

        [Required]
        [MaxLength(14)]
        public required string Bi { get; set; }

        [Required]
        public required byte[] PasswordHash { get; set; }
        [Required]
        public required byte[] Salt { get; set; }

        [MaxLength(500)]
        public string? PhotoPath { get; set; }

        public required DateTime DateOfBirth { get; set; }

        public required bool IsStaff { get; set; }

        public required bool IsActive { get; set; }

        public required bool IsSuperUser { get; set; }

        public required DateTime DateJoined { get; set; }

        [MaxLength(500)]
        public string? FileBiPath { get; set; }

        public required DateTime IssuedOn { get; set; }

        public required DateTime ValidUntil { get; set; }

        [MaxLength(500)]
        public string? FileCvPath { get; set; }

        public required int RoleID { get; set; }

        // Audit
        public required DateTime CreatedAt { get; set; }

        [MaxLength(100)]
        public required string CreatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        [MaxLength(100)]
        public string? UpdatedBy { get; set; }

        // Navigation property
        public virtual Role? Role { get; set; }
    }

}
