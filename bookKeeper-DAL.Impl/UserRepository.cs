using bookKeeper_DAL.Abstract.IInterfaces;
using bookKeeper_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bookKeeper_DAL.Impl
{
    public class UserRepository : IUserRepository 
    {
        private readonly DataBaseContext db;

        public UserRepository(DataBaseContext context)
        {
            db = context;
        }

        public void Create(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public void Update(User user)
        {
            db.Users.Update(user);
            db.SaveChanges();
        }

        public User GetSingle(int id)
        {
            return db.Users.FirstOrDefault(x => x.UserId == id);
        }

        public IEnumerable<User> GetAll()
        {
            return db.Users.ToList();
        }

        public void Delete(int id)
        {
            User res = db.Users.Find(id);
            db.Users.Remove(res);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
}