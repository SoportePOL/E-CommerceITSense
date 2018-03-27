using E_Commerce.Model.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Commerce.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Index(string code)
        {
            ECommerce oECommerce = new ECommerce();
            if (!string.IsNullOrEmpty(code))
            {
                //Get Access Token
                string token = oECommerce.GetToken(code);

                var rrr = token.Split('-');

                Session["DataSession"] = oECommerce.GetUser(rrr[4], token);
                //Get Data User
            }
            return RedirectToAction("Index", "Home");
        }
    }
}