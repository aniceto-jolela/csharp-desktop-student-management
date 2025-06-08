using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpqi.Models
{
    public class Turma
    {
        [Key]
        public int TurmaID { get; set; }

        [Required, MaxLength(15)]
        public required string NameTurma { get; set; } 
        public int ClassRoomID { get; set; } // FK to ClassRoom
        public int ClasseID { get; set; } // FK to Class
        [MaxLength(100)]
        public string? MainTeacher { get; set; } // Name of the main teacher for the class

        [ForeignKey("ClassRoomID")]
        public ClassRoom ClassRoom { get; set; } = null!; // Navigation property

        [ForeignKey("ClasseID")]
        public Classe Classe { get; set; } = null!; // Navigation property


        [NotMapped] // This property is not mapped to the database
        public string ClassRoomNumber => ClassRoom?.ClassRoomNumber ?? string.Empty;
        [NotMapped]
        public string Location => ClassRoom?.Location ?? string.Empty;
        [NotMapped]
        public int MaximumCapacity => ClassRoom?.MaximumCapacity ?? 0;
        [NotMapped]
        public string ClasseName => Classe?.ClasseName ?? string.Empty;
        [NotMapped]
        public string ClassRoomName => $"{ClassRoomNumber} - {Location} ({MaximumCapacity}) - {ClasseName}";

    }
}
