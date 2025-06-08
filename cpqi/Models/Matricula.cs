using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace cpqi.Models
{
    [Index(nameof(BiCedula), IsUnique = true)]
    [Index(nameof(MatriculaNumber), IsUnique = true)]
    public class Matricula
    {
        public enum EstadoMatricula { Activa, Suspensa, Cancelada }

        [Key]
        public int MatriculaID { get; set; } // Primary Key

        [Required]
        public required int MatriculaNumber { get; set; } // Unique registration number for the student

        [Required, MaxLength(100)]
        public required string FatherName { get; set; } = null!; // Name of the father or guardian

        [Required, MaxLength(100)]
        public required string MotherName { get; set; } = null!; // Name of the mother or guardian
        
        [Required]
        public required DateTime DateOfBirth { get; set; } // Date of birth of the student

        [Required, MaxLength(50)]
        public required string NaturalOf { get; set; } = null!; // Place of birth of the student

        public int ProvinceID { get; set; } // Province of the student

        [Required, MaxLength(50)]
        public required string ResideEm { get; set; } = null!; // Place of residence

        [Required, MaxLength(50)]
        public required string Bairro { get; set; } = null!; // Neighborhood of residence

        [Required, MaxLength(50)]
        public required string Rua { get; set; } = null!; // Street of residence

        [Required, MaxLength(10)]
        public required string HouseNumber { get; set; } = null!; // House number

        [Required, MaxLength(20)]
        public required string BiCedula { get; set; } = null!; // ID card number (BI or Cedula)

        [Required]
        public required DateTime IssuedOn { get; set; } // Date when the ID card was issued

        [Required]
        public required DateTime ValidUntil { get; set; } // Validity period of the ID card

        public int TurmaID { get; set; } // Foreign Key to Turma

        [MaxLength(100)]
        public string? TransferidoOfSchool { get; set; } // Name of the school from which the student was transferred

        [MaxLength(100)]
        public string? LocalizadoEm { get; set; } // Location where the student is currently located

        [MaxLength(20)]
        public string? PhoneFather { get; set; } // Father's phone number

        [MaxLength(20)]
        public string? PhoneMother { get; set; } // Mother's phone number

        [Required, MaxLength(10)]
        public required string Patologia { get; set; } = "Não"; // Default pathology is "Not"

        [Required, MaxLength(10)]
        public required string IsUsingAnyMedication { get; set; } = "Não"; // Default is "Not" medication usage
        
        [MaxLength(500)]
        public string? CopyOfReceitaPath { get; set; } // Optional copy of the prescription

        [MaxLength(500)]
        public string? PhotoPath { get; set; }

        [Required]
        public required DateTime DateMatricula { get; set; } = DateTime.Now; // Date of registration

        public int InscricaoID { get; set; } // Foreign Key to Inscricao
        
        public EstadoMatricula Status { get; set; } = EstadoMatricula.Activa; // Default status is "Activa"/"Suspensa"/ "Cancelada" 
       
        public bool IsActive { get; set; } = true; // Default to active

        // Audit
        public required DateTime CreatedAt { get; set; }

        [Required, MaxLength(100)]
        public required string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }

        [MaxLength(100)]
        public string? UpdatedBy { get; set; }

        // Navigation property
        [ForeignKey("InscricaoID")]
        public Inscricao Inscricao { get; set; } = null!; // Navigation property
        
        [ForeignKey("TurmaID")]
        public Turma Turma { get; set; } = null!; // Navigation property

        [ForeignKey("ProvinceID")]
        public Province Province { get; set; } = null!; // Navigation property
    }
}
