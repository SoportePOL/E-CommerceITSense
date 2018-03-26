using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.Models.ECommerce.Shipments
{
    public class Free
    {
        public string methods { get; set; }
        public string accepted_methods { get; set; }
        public List<Rule> rule { get; set; }
        public string flat { get; set; }

    }
}
