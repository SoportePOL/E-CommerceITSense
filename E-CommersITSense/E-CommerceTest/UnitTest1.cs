﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using E_Commerce.Model.Controller;
using E_Commerce.Model.Models.General;

namespace E_CommerceTest 
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetCategories()
        {
            ECommerce ec = new ECommerce();
            var result = ec.GetCategories(Enumerations.enumCountries.MCO.ToString());
        }

        [TestMethod]
        public void GetCategory()
        {
            ECommerce ep = new ECommerce();
            var result = ep.GetCategory("MCO6934");//Accesorios para carro

        }
    }
}