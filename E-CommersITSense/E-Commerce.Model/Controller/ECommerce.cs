using E_Commerce.Model.Models.ECommerce;
using E_Commerce.Model.Models.ECommerce.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.Controller
{
    public class ECommerce
    {
        public string GetUrlAuthorization()
        {
            return E_Commerce.Model.DAL.Controller.ECommerceDataController.Instance.GetUrlAuthorization();
        }

        public string GetToken(string code)
        {
            return E_Commerce.Model.DAL.Controller.ECommerceDataController.Instance.GetToken(code);
        }

        public User SearchUser(string id)
        {
            return E_Commerce.Model.DAL.Controller.ECommerceDataController.Instance.SearchUser(id);
        }

        public List<Category> GetCategories()
        {
            return E_Commerce.Model.DAL.Controller.ECommerceDataController.Instance.GetCategories();
        }
    }
}
