using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.Models.ECommerce.Products
{
    public class Items
    {
        public Accepts_mercadopago accepts_mercadopago { get; set; }
        public bool automatic_relist { get; set; }
        public int available_quantity { get; set; }
        public string base_price { get; set; }
        public string buying_mode { get; set; }
        public string catalog_product_id { get; set; }
        public string category_id { get; set; }
        public string condition { get; set; }
        public string coverage_areas { get; set; }
        public string currency_id { get; set; }
        public DateTime date_created { get; set; }
        public string descriptions { get; set; }
        public Differential_pricing differential_pricing { get; set; }
        public string domain_id { get; set; }
        public string end_time { get; set; }
        public string expiration_time { get; set; }
        public string fee { get; set; }
        public Geolocation geolocation { get; set; }
        public string id { get; set; }
        public string initial_quantity { get; set; }
        public string international_delivery_mode { get; set; }
        public string inventory_id { get; set; }
        public string last_updated { get; set; }
        public string listing_source { get; set; }
        public string listing_type_id { get; set; }
        public Location location { get; set; }
        public Non_mercado_pago_payment_methods non_mercado_pago_payment_methods { get; set; }
        public string official_store_id { get; set; }
        public string original_price { get; set; }
        public string parent_item_id { get; set; }
        public string permalink { get; set; }
        public Pictures pictures { get; set; }
        public string price { get; set; }
        public Sale_terms sale_terms { get; set; }
        public string secure_thumbnail { get; set; }
        public Seller_address seller_address { get; set; }
        public Seller_contact seller_contact { get; set; }
        public string seller_custom_field { get; set; }
        public string seller_id { get; set; }
        public Shipping shipping { get; set; }
        public string site_id { get; set; }
        public string sold_quantity { get; set; }
        public string start_time { get; set; }
        public string status { get; set; }
        public string stop_time { get; set; }
        public string sub_status { get; set; }
        public string subtitle { get; set; }
        public string tags { get; set; }
        public string thumbnail { get; set; }
        public string title { get; set; }
        public string total_listing_fee { get; set; }
        public Variations variations { get; set; }
        public string video_id { get; set; }
        public string warranty { get; set; }




    }
}
