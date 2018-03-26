using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.Models.ECommerce.Shipments
{
    public class ShipmentswithoutCategory
    {
        public string mode { get; set; }
        public List<Logistic_types> logistic_types { get; set; }
        public List<Shipping_attributes> shipping_attributes{ get; set; }

    }
}
