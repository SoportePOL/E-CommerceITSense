using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.Models.ECommerce.Products
{
    public class Rule
    {
        public bool @default { get; set; }
        public string country { get; set; }
        public bool free_shipping_flag { get; set; }
        public bool value { get; set; }
    }
}
