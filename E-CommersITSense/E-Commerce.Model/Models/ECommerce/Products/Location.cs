using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.Models.ECommerce.Products
{
    public class Location
    {
        public string address_line { get; set; }
        public City city { get; set; }
        public Country country { get; set; }
        public Neighborhood neighborhood { get; set; }
        public State state { get; set; }
        public string zip_code { get; set; }

    }
}
