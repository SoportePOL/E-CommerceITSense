using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.Models.ECommerce.Products
{
    public class Shipping
    {
        public string dimensions { get; set; }
        public string free_shipping { get; set; }
        public string local_pick_up { get; set; }
        public string logistic_type { get; set; }
        public string methods { get; set; }
        public string mode { get; set; }
        public string profile_id { get; set; }
        public string store_pick_up { get; set; }
        public string tags { get; set; }
    }
}
