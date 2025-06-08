using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpqi.Models
{
    public class Classe
    {
        [Key]
        public int ClasseID { get; set; }

        [Required, MaxLength(15)]
        public required string ClasseName { get; set; }
        public ICollection<Turma> Turmas { get; set; } = [];

    }
}
