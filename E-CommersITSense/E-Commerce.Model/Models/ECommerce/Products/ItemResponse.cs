using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.Models.ECommerce.Products
{
    public class ItemResponse
    {
        public string site_id { get; set; }
        //public Paging paging { get; set; }
        public List<Item> results { get; set; }
        //public List<string> secondary_results { get; set; }
       // public List<string> related_results { get; set; }
       // public Sort sort { get; set; }
       // public List<Available_sorts> available_sorts { get; set; }

    }
}
