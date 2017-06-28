using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.Models
{
    public class CustomerDemographic
    {
        public int CustomerDemographicID { get; set; }
        public string CustomerDesc { get; set; }

        public ICollection<CustomerCustomerDemo> CustomerCustomerDemos { get; set; }
    }
}
