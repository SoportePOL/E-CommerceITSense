using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.Models.ECommerce.Shipments
{
    public class Rule
    {
        public bool @default { get; set; }
        public string free_mode { get; set; }
        public object value { get; set; }
        public bool free_shipping_flag { get; set; }
    }
}
