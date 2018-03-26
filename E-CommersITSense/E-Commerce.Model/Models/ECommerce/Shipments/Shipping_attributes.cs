using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.Models.ECommerce.Shipments
{
    public class Shipping_attributes
    {
        public string dimensions { get; set; }

        public string costs { get; set; }
        public List<Free> free { get; set; }
        public string local_pick_up { get; set; }


    }
}
