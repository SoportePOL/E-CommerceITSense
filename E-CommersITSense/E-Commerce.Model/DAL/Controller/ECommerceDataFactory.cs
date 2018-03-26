using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.DAL.Controller
{
    internal class ECommerceDataFactory
    {
        public E_Commerce.Model.Interface.IECommerce GetEComerceInstance()
        {
            Type typetoreturn = Type.GetType("E_Commerce.Model.DAL.ApiML.ECommerce_ApiML,E-Commerce.Model");
            
            E_Commerce.Model.Interface.IECommerce oRetorno = (E_Commerce.Model.Interface.IECommerce)Activator.CreateInstance(typetoreturn);
            return oRetorno;
        }
    }
}
