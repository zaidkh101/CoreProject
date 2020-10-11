using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProjectRemasterd.Models
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string FbUrl { get; set; }
        public string TwUrl { get; set; }
        public string LinkedInUrl { get; set; }
        public string EmailUrl { get; set; }
        public bool IsActive { get; set; }
        public string SupplierImage { get; set; }
    }
}
