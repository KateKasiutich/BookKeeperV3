using bookKeeper_DAL.Abstract.IInterfaces;
using bookKeeper_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookKeeper.Tests
{
    class MockUserRepository : IUserRepository
    {
        public Dictionary<int, User> Users;

        public void Create(User item)
        {
            Users.Add(item.UserId, item);
        }

        public void Delete(int id)
        {
            Users.Remove(id);
        }

        public void Dispose()
        {
            Users.Clear();
        }

        public IEnumerable<User> GetAll()
        {
            return Users.Values;
        }

        public User GetByEmail(string email)
        {
            return Users.FirstOrDefault(user => user.Email == email);
        }

        public User GetSingle(int id)
        {
            return Users[id];
        }

        public void Save()
        {
            //do nothing
        }

        public void Update(User item)
        {
            Users[item.UserId] = item;
        }
    }
}
