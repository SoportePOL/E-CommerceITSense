using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.Models.ECommerce.Products
{
    public class Item
    {
        public string id { get; set; }
        public string site_id  { get; set; }
        public string title { get; set; }
        public int seller_id { get; set; }
        public string category_id { get; set; }
        public int? official_store_id { get; set; }
        public int price { get; set; }
        public int base_price { get; set; }
        public int? original_price { get; set; }
        public string currency_id { get; set; }
        public int initial_quantity { get; set; }
        public int available_quantity { get; set; }
        public int sold_quantity { get; set; }
        public List<string> sale_terms { get; set; } 
        public string buying_mode { get; set; }
        public string listing_type_id { get; set; }
        public string start_time { get; set; }
        public string stop_time { get; set; }
        public string condition { get; set; }
        public string permalink { get; set; }
        public string thumbnail { get; set; }
        public string secure_thumbnail { get; set; }
        public List<Pictures> pictures { get; set; }
        public string video_id { get; set; }
        public object descriptions { get; set; } 
        public bool accepts_mercadopago { get; set; }
       public List<string> non_mercado_pago_payment_methods { get; set; }
       // public Shipping shipping { get; set; } 
        public string international_delivery_mode { get; set; }
        public Seller_address seller_address { get; set; }
        public string seller_contact { get; set; }
        public Location location { get; set; }
        public Geolocation geolocation { get; set; }
        public List<string> coverage_areas { get; set; } 
        public List<Attributes> attributes { get; set; }
        public List<string> warnings { get; set; } 
        public string listing_source { get; set; }
        public List<string> variations { get; set; } 
        public string status { get; set; }
        public List<string> sub_status { get; set; }
        public List<string> tags { get; set; } 
        public string warranty { get; set; }
        public string catalog_product_id { get; set; }
        public string domain_id { get; set; }
        public string parent_item_id { get; set; }
        //public string differential_pricing { get; set; }
        public List<string> deal_ids { get; set; } 
        public bool automatic_relist { get; set; }
        public string date_created { get; set; }
        public string last_updated { get; set; }

   }
}
