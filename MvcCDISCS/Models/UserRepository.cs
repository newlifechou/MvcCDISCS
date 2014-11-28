using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCDISCS.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class UserRepository
    {
        CompanyContext db = new CompanyContext();
        public bool ValidateUser(string userName, string passWord)
        {
            return db.admin.Any(o => o.UserName == userName && o.Password == passWord);
        }
    }
}