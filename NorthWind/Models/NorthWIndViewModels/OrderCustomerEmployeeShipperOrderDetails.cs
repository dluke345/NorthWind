using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.Models.NorthWIndViewModels
{
    public class OrderCustomerEmployeeShipperOrderDetails
    {
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
        public IEnumerable<Shipper> Shippers { get; set; }
        public IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}
