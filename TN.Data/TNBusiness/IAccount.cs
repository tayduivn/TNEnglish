using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TN.Data.Model;

namespace TN.Data.TNBusiness
{
    public interface IAccount
    {
        Account LoginAccount(string username, string password);

    }
}
