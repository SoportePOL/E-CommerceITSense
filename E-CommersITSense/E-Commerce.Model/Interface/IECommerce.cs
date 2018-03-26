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
        bool GetToken(string code);
        string SearchUser(string id);
    }
}
