using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Product name cannot be longer than 50 characters")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        [Display(Name = "Unit Price")]
        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }
        [Display(Name = "Units In Stock")]
        public int UnitsInStock { get; set; }
        [Display(Name = "Units On Order")]
        public int UnitsOnOrder { get; set; }
        [Display(Name = "Reorder Level")]
        public int ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

        public Supplier Supplier { get; set; }
        public Category Category { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
