using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProjectRemasterd.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [Display(Name ="Product Name")]
        public string ProductName { get; set; }
        public string ProductDescrption { get; set; }
        [Display(Name ="Picture")]
        public string ProductImage { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public string MCountry { get; set; }
        public string Status { get; set; }
        public int SupplierID { get; set; }
        public Supplier Supplier { get; set; }
        public bool IsActive { get; set; }

    }
}
