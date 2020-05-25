using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bookKeeper_DTO
{
    public class AuthDto
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public AuthDto(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}