﻿using E_Commerce.Model.Models.ECommerce;
using E_Commerce.Model.Models.ECommerce.Products;
using E_Commerce.Model.Models.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.Controller
{
    public class ECommerce
    {

        public ECommerce(){}

        public ECommerce(string code)
        {
            
        }


        public string GetUrlAuthorization()
        {
            return E_Commerce.Model.DAL.Controller.ECommerceDataController.Instance.GetUrlAuthorization();
        }

        public string GetToken(string code)
        {
            return E_Commerce.Model.DAL.Controller.ECommerceDataController.Instance.GetToken(code);
        }

        public User GetUser(string id)
        {
            return E_Commerce.Model.DAL.Controller.ECommerceDataController.Instance.GetUser(id);
        }

        public User GetUser(string id, string access_token)
        {
            return E_Commerce.Model.DAL.Controller.ECommerceDataController.Instance.GetUser(id, access_token);
        }

        public List<Category> GetCategories(string country)
        {
            return E_Commerce.Model.DAL.Controller.ECommerceDataController.Instance.GetCategories(country);
        }

     
        public Category GetCategory(string categoryId)
        {
            return E_Commerce.Model.DAL.Controller.ECommerceDataController.Instance.GetCategory(categoryId);
        }

        public Item GetItem(string itemId)
        {
            return E_Commerce.Model.DAL.Controller.ECommerceDataController.Instance.GetItem(itemId);
        }

        public ItemResponse GetItems(string country, string CategoryId, Enumerations.enumTypeSearch type)
        {
            return E_Commerce.Model.DAL.Controller.ECommerceDataController.Instance.GetItems(country, CategoryId, type);
        }
        
    }
}
