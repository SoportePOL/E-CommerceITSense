using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.Models.ECommerce.Products
{
    public class Settings
    {
        public bool adult_content { get; set; }
        public bool buying_allowed { get; set; }
        public List<object> buying_modes { get; set; }
        public object catalog_domain { get; set; }
        public string coverage_areas { get; set; }
        public List<string> currencies { get; set; }
        public bool fragile { get; set; }
        public string immediate_payment { get; set; }
        public string item_conditions { get; set; }
        public bool items_reviews_allowed { get; set; }
        public bool listing_allowed { get; set; }
        public int max_description_length { get; set; }
        public int max_pictures_per_item { get; set; }
        public int max_pictures_per_item_var { get; set; }
        public int max_sub_title_length { get; set; }
        public int max_title_length { get; set; }
        public object maximum_price { get; set; }
        public object minimum_price { get; set; }
        public object mirror_category { get; set; }
        public object mirror_master_category { get; set; }
        public string mirror_slave_categories { get; set; }
        public string price { get; set; }
        public string reservation_allowed { get; set; }
        public List<object> restrictions { get; set; }
        public bool rounded_address { get; set; }
        public string seller_contact { get; set; }
        public List<string> shipping_modes { get; set; }
        public List<string> shipping_options { get; set; }
        public string shipping_profile { get; set; }
        public bool show_contact_information { get; set; }
        public string simple_shipping { get; set; }
        public string stock { get; set; }
        public string sub_vertical { get; set; }
        public bool subscribable { get; set; }
        public List<object> tags { get; set; }
        public string vertical { get; set; }
        public string vip_subdomain { get; set; }
        public string total_items_in_this_category { get; set; }
    }
}
