using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.Models.ECommerce
{
    public class SellerReputation
    {
        public object level_id { get; set; }
        public object power_seller_status { get; set; }
        public Transactions transactions { get; set; }
        public Metrics metrics { get; set; }
    }
    
}
