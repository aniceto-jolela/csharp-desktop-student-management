using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpqi.Models
{
    public class Period
    {
        [Key]
        public int PeriodID { get; set; }

        [Required, MaxLength(20)]
        public required string PeriodName { get; set; }
    }
}
