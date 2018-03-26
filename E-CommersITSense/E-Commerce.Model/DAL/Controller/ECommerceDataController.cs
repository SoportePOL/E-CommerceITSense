using E_Commerce.Model.Models.ECommerce;
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

        public User SearchUser(string id) {
            return DataFactory.SearchUser(id);
        }
    }
}
