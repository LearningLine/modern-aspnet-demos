using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using Security2.Models;

namespace Security2.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login(string ReturnUrl)
        {

            return View(new LoginModel() {ReturnUrl = ReturnUrl});
        }

        [HttpPost]
        public ActionResult Login(LoginModel login)
        {
            if (!string.IsNullOrEmpty(login.UserName) && login.UserName == login.Password.ToLower())
            {
                ClaimsIdentity id = new ClaimsIdentity(
                    new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, login.UserName),
                        new Claim(ClaimTypes.Email, "test@test.com"),
                        new Claim(ClaimTypes.Country, "USA"),

                    }, DefaultAuthenticationTypes.ApplicationCookie);
                this.HttpContext.GetOwinContext().Authentication.SignIn(
                    id);
                return Redirect(login.ReturnUrl);
            }
            ModelState.AddModelError("Password", "Password required");
            return View(login);
        }
    }
}