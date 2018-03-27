using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.Models.ECommerce.Products
{
    public class Shipping
    {
        public string mode { get; set; }
        public List<Free_methods> free_methods { get; set; }
        public List<string> mandatory_free_shipping { get; set; }
        public List<string> tags { get; set; }
        public string dimensions { get; set; }
        public bool local_pick_up { get; set; }
        public bool free_shipping { get; set; }
        public string logistic_type { get; set; }
        public bool store_pick_up { get; set; }
    }
}
