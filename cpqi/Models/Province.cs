using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpqi.Models
{
    public class Province
    {
        [Key]
        public int ProvinceID { get; set; }
        
        [Required]
        [MaxLength(100)]
        public required string ProvinceName { get; set; } // Name of the province
    }
}
