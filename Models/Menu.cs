using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProjectRemasterd.Models
{
    public class Menu
    {
        public int MenuID { get; set; }
        public string MenuItem { get; set; }
        public string MenuUrl { get; set; }
        public int RoleID { get; set; }
        public Role Role { get; set; }
        public bool IsActive { get; set; }
    }
}
