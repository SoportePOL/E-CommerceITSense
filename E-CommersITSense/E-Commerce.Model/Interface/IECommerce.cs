using E_Commerce.Model.Models.ECommerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.Interface
{
    interface IECommerce
    {
        string GetUrlAuthorization();
        string GetToken(string code);
        User SearchUser(string id);
    }
}
