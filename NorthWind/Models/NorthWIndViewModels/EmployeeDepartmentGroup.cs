using System;
using System.ComponentModel.DataAnnotations;

namespace NorthWind.Models.NorthWIndViewModels
{
    public class EmployeeDepartmentGroup
    {
        [DataType(DataType.Date)]
        public string Department { get; set; }
        public string EmployeeNames { get; set; }

        public int EmployeeCount { get; set; }
    }
}
