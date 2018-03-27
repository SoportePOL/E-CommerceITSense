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
            return View(Session["DataSession"]);
        }
    }
}