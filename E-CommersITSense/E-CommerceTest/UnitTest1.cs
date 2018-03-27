using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using E_Commerce.Model.Controller;

namespace E_CommerceTest 
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetCategories()
        {
            ECommerce ec = new ECommerce();

            var result = ec.GetCategories();
            
        }

        [TestMethod]
        public void GetProduct()
        {
            ECommerce ep = new ECommerce();

            var result = ep.GetProducts();

        }
    }
}
