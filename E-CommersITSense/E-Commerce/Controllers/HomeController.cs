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
            ECommerce asdf = new ECommerce();
            if (!string.IsNullOrEmpty(code))
            {
                //Get Access Token
                asdf.GetToken(code);

                //Get Data User
                asdf.SearchUser("198663698");
                //198663698     APP_USR-2828323412798944-032610-809f08edf726360d1c189fde7f2337c1-198663698
                return View();
            }

            return Redirect(asdf.GetUrlAuthorization());
        }
    }
}