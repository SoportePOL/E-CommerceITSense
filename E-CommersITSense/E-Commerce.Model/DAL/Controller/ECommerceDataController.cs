using E_Commerce.Model.Models.ECommerce;
using E_Commerce.Model.Models.ECommerce.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.DAL.Controller
{
    public class ECommerceDataController : E_Commerce.Model.Interface.IECommerce
    {

        private static E_Commerce.Model.Interface.IECommerce oInstance;
        internal static E_Commerce.Model.Interface.IECommerce Instance
        {
            get
            {
                if (oInstance == null)
                    oInstance = new ECommerceDataController();
                return oInstance;
            }
        }

        private E_Commerce.Model.Interface.IECommerce DataFactory;

        #region constructor

        public ECommerceDataController()
        {
            ECommerceDataFactory factory = new ECommerceDataFactory();
            DataFactory = factory.GetEComerceInstance();
        }

        #endregion

        public string GetUrlAuthorization()
        {
            return DataFactory.GetUrlAuthorization();
        }
        public string GetToken(string code)
        {
            return DataFactory.GetToken(code);
        }

        public User GetUser(string id) {
            return DataFactory.GetUser(id);
        }

        public User GetUser(string id, string access_token)
        {
            return DataFactory.GetUser(id, access_token);
        }

        public List<Category> GetCategories(string country)
        {
            return DataFactory.GetCategories(country);
        }

        public Category GetCategory(string categoryId)
        {
            return DataFactory.GetCategory(categoryId);
        }

        public Item GetItem(string itemId)
        {
            return DataFactory.GetItem(itemId);
        }

        public List<Item> GetItems(string country, string CategoryId)
        {
            return DataFactory.GetItems(country, CategoryId);
        }

        public ItemResponse GetItemResponse()
        {
            return DataFactory.GetItemResponse();
        }



    }
}
