using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.Models.ECommerce.Products
{
    public class Seller_address
    {
        public string comment { get; set; }
        public string address_line { get; set; }
        public string zip_code { get; set; }
        public City city { get; set; }


    }
}
