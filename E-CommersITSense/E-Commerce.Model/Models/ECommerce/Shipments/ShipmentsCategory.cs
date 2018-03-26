using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.Models.ECommerce.Shipments
{
    public class ShipmentsCategory
    {
        public string category_id { get; set; }
        public string item_currency { get; set; }
        public string dimensions { get; set; }
        public Catalog catalog { get; set; }
    }
}
