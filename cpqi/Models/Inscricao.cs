using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using static cpqi.Models.Matricula;

namespace cpqi.Models
{
    [Index(nameof(FullName), IsUnique = true)]
    [Index(nameof(InscricaoNumber), IsUnique = true)]
    public class Inscricao
    {
        public enum EstadoInscricao { Pendente, Aprovado, Rejeitado }

        [Key]
        public int InscricaoID { get; set; }
        
        public int InscricaoNumber { get; set; } // Unique registration number for the student

        [Required, MaxLength(100)]
        public required string FullName { get; set; }

        public int ClasseID { get; set; } // FK to Class
        public int PeriodID { get; set; } // FK to Period

        [Required, Phone, MaxLength(20)]
        public required string Phone1 { get; set; } = null!;

        [Phone]
        [MaxLength(20)]
        public string? Phone2 { get; set; } // Optional phone number
        [Required]
        public required DateTime DateInscricao{ get; set; }

        [Required, MaxLength(100)]
        public required string EncarregadoDeEducacao { get; set; } = null!; // Name of the guardian or parent
        
        public EstadoInscricao Status { get; set; } = EstadoInscricao.Pendente; // Default status is "Pending"/ "Approved" / "Rejected"

        public bool IsActive { get; set; } = true; // Default to active
        public bool IsStudent { get; set; } = false; // Default to student

        // Audit
        [Required]
        public required DateTime CreatedAt { get; set; }

        [Required, MaxLength(100)]
        public required string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }

        [MaxLength(100)]
        public string? UpdatedBy { get; set; }

        // Navigation property
        [ForeignKey("ClasseID")]
        public Classe Classe { get; set; } = null!; // Navigation property

        [ForeignKey("PeriodID")]
        public Period Period { get; set; } = null!; // Navigation property

        // Collection of Matriculas (Enrollments) related to this Inscricao
        public ICollection<Matricula> Matriculas { get; set; } = new List<Matricula>(); // Navigation in two direction

        // Computed/Derived properties (not mapped to DB)
        [NotMapped]
        public string ClasseName => Classe?.ClasseName ?? string.Empty;
        [NotMapped]
        public string PeriodName => Period?.PeriodName ?? string.Empty;

    }
}
