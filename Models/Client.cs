using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProjectRemasterd.Models
{
    public class Client
    {

        public int ClientID { get; set; }
        public string ClientName { get; set; }
        public string ClientImage { get; set; }
        public string ClientDescription { get; set; }
        public string Job { get; set; }
        public bool IsActive { get; set; }
    }
}
