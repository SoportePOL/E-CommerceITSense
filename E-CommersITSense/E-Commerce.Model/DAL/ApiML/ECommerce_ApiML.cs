using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HttpParamsUtility;
using MercadoLibre.SDK;
using MercadoLibre.SDK.Meta;

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
                Credentials = new MeliCredentials(MeliSite.Colombia, 2828323412798944, "ZbSfa4rQGXPRGnImNYB06vGPSnUO75Z5")
            };
            //m.Credentials.AccessToken = "APP_USR-2828323412798944-032610-a74cd673dd93e07f2b48fc8d35681685-198663698";
        }
        #endregion

        public string GetUrlAuthorization()
        {
            return this.m.GetAuthUrl(2828323412798944, MeliSite.Colombia, "http://localhost:9680/Home/Index");
        }

        public void RefreshToken(string code)
        {
            

           // m.Credentials.TokensChanged += (sender, args) => { doSomethingWithNewTokenValues(args.Info); };

            var success = this.m.AuthorizeAsync(code, "");
        }

        public bool GetToken(string code)
        {
          
            this.m.AuthorizeAsync(code, "http://localhost:9680/Home/Index");

            //var tt =  this.m.AuthorizeAsync(code, "http://localhost:9680/Home/Index").Result;
            return false;
        }

        public string SearchUser(string id)
        {
            using (var client = new HttpClient())
            {
                var p = new HttpParams()
                     .Add("access_token", "APP_USR-2828323412798944-032610-809f08edf726360d1c189fde7f2337c1-198663698");
                     //.Add("id", id);

                var result = Task.Run(async () => await m.GetAsync("/users/198663698", p)).Result;

                var Response = result.Content.ReadAsStringAsync().Result;

            }

            return "Hola";
        }
    }
}
