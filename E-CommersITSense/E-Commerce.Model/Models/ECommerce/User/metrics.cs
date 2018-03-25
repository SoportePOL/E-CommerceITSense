using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.Models.ECommerce
{
    public class Metrics
    {
        public Sales sales { get; set; }
        public Claims claims { get; set; }
        public DelayedHandlingTime delayed_handling_time { get; set; }


    }
}
