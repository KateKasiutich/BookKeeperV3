using bookKeeper_DAL.Abstract.IInterfaces;
using bookKeeper_DAL.Impl.Repositories;
using bookKeeper_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bookKeeper_DAL.Impl
{
    public class UserRepository : EFCoreRepository<int, User>, IUserRepository
    {
        public UserRepository(DataBaseContext context) : base(context)
        { }
    }
}