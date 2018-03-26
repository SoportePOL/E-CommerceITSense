using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.Model.Models.ECommerce;
using HttpParamsUtility;
using MercadoLibre.SDK;
using MercadoLibre.SDK.Meta;
using Newtonsoft.Json;

namespace E_Commerce.Model.DAL.ApiML
{
    internal class ECommerce_ApiML : E_Commerce.Model.Interface.IECommerce
    {
        private MeliApiService m;
        #region constructor
        public ECommerce_ApiML()
        {
            this.m = new MeliApiService()
            {
                Credentials = new MeliCredentials(MeliSite.Colombia, 3445471109297649, "6aEmQThYQOgWhYEZI7eUEw7tgf4BIP4O")
            };
        }
        #endregion

        public string GetUrlAuthorization()
        {
            return this.m.GetAuthUrl(3445471109297649, MeliSite.Colombia, "http://localhost:9680/Home/Index");
        }

        public void RefreshToken(string code)
        {
            

           // m.Credentials.TokensChanged += (sender, args) => { doSomethingWithNewTokenValues(args.Info); };

            var success = this.m.AuthorizeAsync(code, "");
        }

        public string GetToken(string code)
        {
            using (var client = new HttpClient())
            {
                var result = Task.Run(async () => await m.AuthorizeAsync(code, "http://localhost:9680/Home/Index")).Result;
                var Response = "";//result.Content.ReadAsStringAsync().Result;
                return Response;
            }

            
        }

        public User SearchUser(string id)
        {
            User oResult = null;
            using (var client = new HttpClient())
            {
                var p = new HttpParams()
                     .Add("access_token", "APP_USR-3445471109297649-032612-1b975a880319aafb667dc2fe1b177217-143566619");

                var result = Task.Run(async () => await m.GetAsync("/users/"+ id, p)).Result;

                string Response = result.Content.ReadAsStringAsync().Result;

                oResult = JsonConvert.DeserializeObject<User>(Response);
                
            }

            return oResult;
        }
    }
}
