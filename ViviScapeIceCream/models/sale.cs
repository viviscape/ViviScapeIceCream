using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViviScapeIceCream.models
{
  public  class sale
    {
        public int sale_id { get; set; }
        public int flavor_id { get; set; }
        public int qty { get; set; }
        public decimal cost { get; set; }
        public decimal price { get; set; }
        public string  date_sold { get; set; }
    }
}
