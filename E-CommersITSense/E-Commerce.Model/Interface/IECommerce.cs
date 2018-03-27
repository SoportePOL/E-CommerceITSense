using E_Commerce.Model.Models.ECommerce;
using E_Commerce.Model.Models.ECommerce.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.Interface
{
    interface IECommerce
    {
        string GetUrlAuthorization();
        string GetToken(string code);
        User GetUser(string id, string access_tocken);
        User GetUser(string id);
        List<Category> GetCategories();

    }
}
