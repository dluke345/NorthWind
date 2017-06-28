using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.Models
{
    public class EmployeeTerritory
    {
        public int EmployeeID { get; set; }
        public int TerritoryID { get; set; }

        public Employee Employee { get; set; }
        public Territory Territory { get; set; }
    }
}
