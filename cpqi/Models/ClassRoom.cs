using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpqi.Models
{
    public class ClassRoom
    {
        [Key]
        public int ClassRoomID { get; set; }
        
        [Required, MaxLength(15)]
        public required string ClassRoomNumber { get; set; }

        public int MaximumCapacity { get; set; }

        [Required, MaxLength(30)]
        public required string Location { get; set; }
        public ICollection<Turma> Turmas { get; set; } = [];
    }
}
