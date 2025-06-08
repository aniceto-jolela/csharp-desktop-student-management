using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cpqi.Models
{
    public class Discipline
    {
        [Key]
        public int DisciplineID { get; set; }
        
        [Required, MaxLength(50)]
        public required string DisciplineName { get; set; }

        [Required, MaxLength(10)]
        public required string DisciplineCode { get; set; }
    }
}
