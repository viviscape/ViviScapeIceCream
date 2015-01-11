using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViviScapeIceCream.models
{
   public class flavor
    {
        public int flavor_id { get; set; }
        public string flavor_name { get; set; }
        public decimal stock { get; set; }
        public decimal cost { get; set; }
        public decimal price { get; set; }
        public bool discontinued { get; set; }
        public bool featured { get; set; }

    }
}
