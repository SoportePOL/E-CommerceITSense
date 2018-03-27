using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_Commerce.Model.Controller;
using E_Commerce.Model;

namespace E_Commerce.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index(string id)
        {
            ECommerce oECommerce = new ECommerce();
            if (!string.IsNullOrEmpty(id))
            {
                var oQuery = oECommerce.GetCategory(id);

                if (oQuery.children_categories.Count == 0)
                {
                    return RedirectToAction("Search","Item",new { id =  id, type = "2" });
                }

                return View(oQuery);
            }
            Model.Models.ECommerce.Products.Category oResult = new Model.Models.ECommerce.Products.Category();
            oResult.children_categories = oECommerce.GetCategories(Model.Models.General.Enumerations.enumCountries.MCO.ToString());

            return View(oResult);
        }
    }
}