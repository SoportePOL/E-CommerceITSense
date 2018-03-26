using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.Models.ECommerce.Products
{
    public class Variations
    {
        public Attribute_combinations attribute_combinations { get; set; }
        public string available_quantity { get; set; }
        public string id { get; set; }
        public string initial_quantity { get; set; }
        public string inventory_id { get; set; }
        public string picture_ids { get; set; }
        public string price { get; set; }
        public Sale_terms sale_terms { get; set; }
        public string seller_custom_field { get; set; }

    }
}
