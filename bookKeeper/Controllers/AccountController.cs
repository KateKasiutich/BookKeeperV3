using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Mvc;
using bookKeeper_DAL.Impl;
using bookKeeper_DTO;
using bookKeeper_Entity;
using System.Data.Entity;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication.Cookies;
using bookKeeper_DAL.Abstract;

namespace bookKeeper.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
    }
}
