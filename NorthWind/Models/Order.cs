using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NorthWind.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Required Date")]
        public DateTime RequiredDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Shipped Date")]
        public DateTime ShippedDate { get; set; }
        public int ShipVia { get; set; }
        public double Freight { get; set; }
        [Display(Name = "Ship Name")]
        public string ShipName { get; set; }
        [Display(Name = "Ship Address")]
        public string ShipAddress { get; set; }
        [Display(Name = "Ship City")]
        public string ShipCity { get; set; }
        [Display(Name = "Ship Region")]
        public string ShipRegion { get; set; }
        [Display(Name = "Ship Postal Code")]
        public string ShipPostalCode { get; set; }
        [Display(Name = "Ship Country")]
        public string ShipCountry { get; set; }

        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
        public Shipper Shipper { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
