using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.Models
{
    public class CustomerCustomerDemo
    {
        public int CustomerID { get; set; }
        public int CustomerDemographicID { get; set; }

        public Customer Customer { get; set; }
        public CustomerDemographic CustomerDemographic { get; set; }
    }
}
