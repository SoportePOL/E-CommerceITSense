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
        public ActionResult Index(string code)
        {
            ECommerce oECommerce = new ECommerce();
            if (!string.IsNullOrEmpty(code))
            {
                //Get Access Token
                oECommerce.GetToken(code);

                //Get Data User
                var dUser =  oECommerce.SearchUser("198663698");

                return View(dUser);
            }

            return Redirect(oECommerce.GetUrlAuthorization());
        }
    }
}