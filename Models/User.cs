using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProjectRemasterd.Models
{
    public class User
    {
        public Guid UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserImage { get; set; }
        public int RoleID { get; set; }
        public Role Role { get; set; }
        public bool IsActive { get; set; }
    }
}
