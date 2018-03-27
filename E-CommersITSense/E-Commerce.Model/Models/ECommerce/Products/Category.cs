using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.Models.ECommerce.Products
{
    public class Category
    {
        public string atributte_types { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string picture { get; set; }
        public string permalink { get; set; }
        public int total_items_in_this_category { get; set; }
        public List<PathFromRoot> path_from_root { get; set; }
        public List<Category> children_categories { get; set; }
        public string attribute_types { get; set; }
        public Settings settings { get; set; }
        public string meta_categ_id { get; set; }
        public bool attributable { get; set; }
    }
}

