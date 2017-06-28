using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.Models
{
    public class Territory
    {
        public int TerritoryID { get; set; }
        [Required]
        [Display(Name = "Territory Name")]
        public string TerritoryName { get; set; }
        public int RegionID { get; set; }

        public Region Region { get; set; }
        public ICollection<EmployeeTerritory> EmployeeTerritories { get; set; }
    }
}
