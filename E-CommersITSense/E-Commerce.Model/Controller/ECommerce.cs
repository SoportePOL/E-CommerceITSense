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

        public bool GetToken(string code)
        {
            return E_Commerce.Model.DAL.Controller.ECommerceDataController.Instance.GetToken(code);
        }

        public string SearchUser(string id)
        {
            return E_Commerce.Model.DAL.Controller.ECommerceDataController.Instance.SearchUser(id);
        }
    }
}
