using E_Commerce.Model.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace E_Commerce.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ECommerce oECommerce = new ECommerce();
            if (Session["DataSession"] != null)
            {
                return View(Session["DataSession"]);
            }
            return Redirect(oECommerce.GetUrlAuthorization());
        }


    }
}