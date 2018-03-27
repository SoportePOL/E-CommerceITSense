using E_Commerce.Model.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Commerce.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Search()
        {
            return View();
        }

        public ActionResult Index(string id)
        {
            ECommerce oECommerce = new ECommerce();
            if (!string.IsNullOrEmpty(id))
            {
                return View(oECommerce.GetItem(id));
            }
            return View();
        }
    }
}