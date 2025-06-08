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
    public class Teacher
    {
        [Key]
        public int TeacherID { get; set; }

        public int UserID { get; set; } // FK to User

        public int DisciplineID { get; set; } // FK to Discipline

        public int PeriodID { get; set; } // FK to Period

        public int TurmaID { get; set; } // FK to Turma

        // Navigation properties
        [ForeignKey("UserID")]
        public User User { get; set; } = null!;

        [ForeignKey("DisciplineID")]
        public Discipline Discipline { get; set; } = null!;

        [ForeignKey("PeriodID")]
        public Period Period { get; set; } = null!;

        [ForeignKey("TurmaID")]
        public Turma Turma { get; set; } = null!;

        // Computed/Derived properties (not mapped to DB)
        [NotMapped]
        public string UserFullName => User?.FullName ?? string.Empty;

        [NotMapped]
        public string DisciplineName => Discipline?.DisciplineName ?? string.Empty;

    }
}
