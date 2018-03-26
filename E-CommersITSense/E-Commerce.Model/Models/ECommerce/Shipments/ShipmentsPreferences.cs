using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.Models.ECommerce.Shipments
{
    public class ShipmentsPreferences
    {
        public string local_pick_up { get; set; }
        public List<Modes> modes { get; set; }
        public List<Free_configurations> free_configurations { get; set; }
        public bool trusted_user { get; set; }
        public string mandatory_settings { get; set; }
        public bool custom_calculator { get; set; }
        public string picking_type { get; set; }
        public string thermal_printer { get; set; }
        public string option { get; set; }
        public string site_id { get; set; }
        public string tags { get; set; }
        public bool carrier_pickup { get; set; }
        public List<History> history { get; set; }

        public string items_combination { get; set; }
        public List<Logistics> logistics { get; set; }
        public string conciliation { get; set; }

    }
}
