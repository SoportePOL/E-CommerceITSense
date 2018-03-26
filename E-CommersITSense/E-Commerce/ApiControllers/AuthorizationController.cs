using E_Commerce.Model.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace E_Commerce.ApiControllers
{
    public class AuthorizationController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string GetToken(string code)
        {
            ECommerce asdf = new ECommerce();
            var asdfadsf = asdf.GetToken(code);

            return "";
        }
        
    }
}