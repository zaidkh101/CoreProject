using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProjectRemasterd.Models
{
    public class Slider
    {
        public int SliderID { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string SliderImage { get; set; }
        public int Discount { get; set; }
        public string SliderDesc { get; set; }
        public decimal Price { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
    }
}
