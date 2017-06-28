using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public int DepartmentID { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Last name cannot be longer than 50 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Bio { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Title cannot be longer than 50 characters")]
        public string Title { get; set; }
        public DateTime HireDate { get; set; }
        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }


        public Department Department { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<EmployeeTerritory> EmployeeTerritories { get; set; }
    }
}
