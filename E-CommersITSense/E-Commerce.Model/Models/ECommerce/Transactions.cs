using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.Models.ECommerce
{
    public class Transactions
    {
        public string period { get; set; }
        public int total { get; set; }
        public int completed { get; set; }
        public int canceled { get; set; }
        public Ratings ratings { get; set; }
    }
}
