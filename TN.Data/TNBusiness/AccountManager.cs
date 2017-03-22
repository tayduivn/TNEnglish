using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TN.Data.Model;

namespace TN.Data.TNBusiness
{
   public class AccountManager:IAccount
    {
     

       public Account LoginAccount(string username, string password)
       {
            try
           {
               using (var db = new EnglishEntities())
               {
                   var query = db.Accounts.FirstOrDefault(x => x.Username.Equals(username) && x.Password.Equals(password));
                   return query;
               }
           }
           catch (Exception e)
           {
               return null;
           }
       }
    }
}
