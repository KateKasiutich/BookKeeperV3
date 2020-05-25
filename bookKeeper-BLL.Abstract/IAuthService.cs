using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bookKeeper_DAL.Abstract
{
    public interface IAuthService
    {
        void Registration(string name, string email, string password);

    }
}