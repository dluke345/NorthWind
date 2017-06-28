using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        [Required]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }
        [Required]
        [Display(Name = "Contact Name")]
        [StringLength(50, ErrorMessage = "Contact name cannot be longer than 50 characters")]
        public string ContactName { get; set; }
        [Display(Name = "Contact Title")]
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        [Display(Name = "Postal Code")]
        public int PostalCode { get; set; }
        [StringLength(25, ErrorMessage = "Country cannot be longer than 25 characters")]
        public string Country { get; set; }
        [StringLength(14, ErrorMessage = "Phone cannot be longer than 14 characters")]
        public string Phone { get; set; }

        public ICollection<Order> Orders { get; set; }
        public ICollection<CustomerCustomerDemo> CustomerCustomerDemos { get; set; }
    }
}
