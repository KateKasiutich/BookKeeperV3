using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bookKeeper_DAL.Abstract
{
    public interface IAuthService
    {
        bool Registration(string name, string email, string password);
        bool Authentication(string email, string password);
        bool SignOut(int userId);
    }
}