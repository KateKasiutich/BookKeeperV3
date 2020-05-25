using bookKeeper_DAL.Abstract;
using bookKeeper_DAL.Abstract.IInterfaces;
using bookKeeper_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bookKeeper_BLL.Impl
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository UserRepo;

        public AuthService(IUserRepository userRepository)
        {
            UserRepo = userRepository;
        }

        public bool Authentication(string email, string password)
        {
            //вот тут я не знаю, что делать и как дальше жить
        }

        public bool Registration(string name, string email, string password)
        {
            bool isRegistered;
            User user = new User();
            user.Name = name;
            user.Email = email;
            user.Password = password;
            UserRepo.Create(user);
            UserRepo.Save();
            return isRegistered = true;
            //вероятно, нужно сделать проверку на валидность введенных данных, но я не уверена, что это здесь
        }

        public bool SignOut(int userId)
        {
            //тут тоже
        }
    }
}