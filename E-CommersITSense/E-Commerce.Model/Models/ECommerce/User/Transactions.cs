using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.Models.ECommerce
{
    public class Transactions
    {
        public int canceled { get; set; }
        public int completed { get; set; }
        public string period { get; set; }
        public Ratings ratings { get; set; }
        public int total { get; set; }
    }

    public class Ratings
    {
        public int negative { get; set; }
        public int neutral { get; set; }
        public int positive { get; set; }

    }
}
