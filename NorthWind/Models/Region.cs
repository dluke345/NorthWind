using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.Models
{
    public class Region
    {
        public int RegionID { get; set; }
        [StringLength(50, ErrorMessage = "Region name cannot be longer than 50 characters")]
        [Required]
        [Display(Name = "Region Name")]
        public string RegionName { get; set; }

        public ICollection<Territory> Territories { get; set; }
    }
}
