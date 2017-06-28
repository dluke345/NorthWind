using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        [Required]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
