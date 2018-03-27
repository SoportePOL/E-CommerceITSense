using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.Model.Models.ECommerce;
using E_Commerce.Model.Models.ECommerce.Products;
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
            return this.m.GetAuthUrl(3445471109297649, MeliSite.Colombia, "http://localhost:9680/Auth/Index");
        }

        public string GetToken(string code)
        {
            using (var client = new HttpClient())
            {
                if (Task.Run(async () => await m.AuthorizeAsync(code, "http://localhost:9680/Auth/Index")).Result)
                {
                    return m.Credentials.AccessToken;
                }
                return null;
            }

            
        }

        public User GetUser(string id, string access_tocken)
        {
            User oResult = null;
            using (var client = new HttpClient())
            {
                var p = new HttpParams()
                     .Add("access_token", access_tocken);

                var result = Task.Run(async () => await m.GetAsync("/users/"+ id, p)).Result;

                string Response = result.Content.ReadAsStringAsync().Result;

                oResult = JsonConvert.DeserializeObject<User>(Response);
                
            }

            return oResult;
        }

        public User GetUser(string id)
        {
            User oResult = null;
            using (var client = new HttpClient())
            {
                var result = Task.Run(async () => await m.GetAsync("/users/" + id, null)).Result;

                string Response = result.Content.ReadAsStringAsync().Result;

                oResult = JsonConvert.DeserializeObject<User>(Response);

            }

            return oResult;
        }


        public List<Category> GetCategories(string country)
        {
            List<Category> oResult = null;
            List<Category> oResult2 = null;
            using (var client = new HttpClient())
            {
                var result = Task.Run(async () => await m.GetAsync("/sites/" + country + "/categories", null)).Result;

                string Response = result.Content.ReadAsStringAsync().Result;
                oResult = JsonConvert.DeserializeObject<List<Category>>(Response);
            }

            if (oResult != null)
            {
                try
                {
                    oResult2 = new List<Category>();
                    oResult.All(x => {


                        /*
                          var rCategory = GetCategory(x.id);
                          rCategory.children_categories.All(z => {
                            z.info_category = GetCategory(z.id);
                            return true;
                        });*/

                        oResult2.Add(GetCategory(x.id));

                        return true;
                    });
                }
                catch (Exception)
                {

                    throw;
                }
                
            }


            return oResult2;
        }

        public Category GetCategory(string categoryId)
        {
            Category oResult = null;
            using (var client = new HttpClient())
            {
                var result = Task.Run(async () => await m.GetAsync("/categories/" + categoryId, null)).Result;

                string Response = result.Content.ReadAsStringAsync().Result;
                oResult = JsonConvert.DeserializeObject<Category>(Response);
                
            }
            
            return oResult;
        }

        public Items GetItems()
        {
            Items oResult = null;
            using (var client = new HttpClient())
            {
                var result = Task.Run(async () => await m.GetAsync("items/MCO448896604", null)).Result;

                string Response = result.Content.ReadAsStringAsync().Result;
                oResult = JsonConvert.DeserializeObject<Items>(Response);

            }

            return oResult;
        }
        ///items/MCO448896604
    }

}

