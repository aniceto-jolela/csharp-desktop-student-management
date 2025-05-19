using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpqi.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public char? Sex { get; set; } // 'M', 'F', 'O' or null
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public byte[] PasswordHash { get; set; } = Array.Empty<byte>();
        public string? PhotoPath { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool IsStaff { get; set; }
        public bool IsActive { get; set; }
        public bool IsSuperUser { get; set; }
        public DateTime DateJoined { get; set; }
        public string? FileBiPath { get; set; }
        public DateTime? IssuedOn { get; set; }
        public DateTime? ValidUntil { get; set; }
        public string? FileCvPath { get; set; }
        public int? RoleID { get; set; }

        // Audit
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }

        // Navigation property !
        public Role? Role { get; set; }


    }

}
