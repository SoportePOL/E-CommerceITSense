using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.Models.ECommerce
{
    public class Status
    {
        public string site_status { get; set; }
        public List list { get; set; }
        public Buy buy { get; set; }
        public Sell sell { get; set; }
        public bool mercadopago_tc_accepted { get; set; }
        public string immediate_payment { get; set; }
    }
}
