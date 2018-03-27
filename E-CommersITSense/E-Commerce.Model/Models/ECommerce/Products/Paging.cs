using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.Models.ECommerce.Products
{
    public class Paging
    {
        public int total { get; set; }
        public int offset { get; set; }
        public int limit { get; set; }
        public int primary_results { get; set; }
    }
}
