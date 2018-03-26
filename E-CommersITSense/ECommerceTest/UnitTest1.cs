using Microsoft.VisualStudio.TestTools.UnitTesting;
using E_Commerce.Model.Controller;

namespace ECommerceTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test()
        {
            ECommerce asdf = new ECommerce();
            var respuesta = asdf.GetCategories();
        }
    }
}
