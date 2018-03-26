using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.Models.ECommerce
{
    public class User
    {
        public int id { get; set; }
        public string nickname { get; set; }
        public DateTime registration_date { get; set; }
        public string country_id { get; set; }
        public Address address { get; set; }
        public string user_type { get; set; }
        public List<string> tags { get; set; }
        public object logo { get; set; }
        public int points { get; set; }
        public string site_id { get; set; }
        public string permalink { get; set; }
        public SellerReputation seller_reputation { get; set; }
        public BuyerReputation buyer_reputation { get; set; }
        public object status { get; set; }

    }

}
