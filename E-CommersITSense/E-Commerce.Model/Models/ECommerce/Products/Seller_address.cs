using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.Models.ECommerce.Products
{
    public class Seller_address
    {
        public string address_line { get; set; }
        public City city { get; set; }
        public string comment { get; set; }
        public Country country { get; set; }
        public string id { get; set; }
        public State state { get; set; }
        public string zip_code { get; set; }

    }
}
