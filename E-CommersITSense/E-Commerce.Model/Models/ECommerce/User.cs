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
        public string first_name { get; set; }
        public string Last_name { get; set; }
        public string country_id { get; set; }
        public string email { get; set; }
        public Identification identification { get; set; }
        public Phone phone { get; set; }
        public Address address { get; set; }
        public string user_type { get; set; }
        public List<string> tags { get; set; }
        public object logo { get; set; }
        public int points { get; set; }
        public string site_id { get; set; }
        public string permalink { get; set; }
        public string seller_experience { get; set; }
        public string seller_reputation { get; set; }
        public string buyer_reputation { get; set; }
        public string status { get; set; }
    }

}
