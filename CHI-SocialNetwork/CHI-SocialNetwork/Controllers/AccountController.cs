using CHI_SocialNetwork.Controllers;
using CHI_SocialNetwork.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CHI_SocialNetwork.Controllers
{
    public class AccountController : BaseController
    {
        [HttpGet]
        public ActionResult SignUp()
        {
            return View("Register");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(SignupViewModel signup)
        {
            if (Security.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

         

            if (!ModelState.IsValid)
            {
                return View("Register", signup);
            }

            if (Security.DoesUserExist(signup.Username))
            {
                ModelState.AddModelError("Username", "Username is already taken.");

                return View("Register", signup);
            }

            Security.CreateUser(signup);

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginSignupViewModel model)
        {
            if (Security.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            model.Signup = new SignupViewModel();

            var login = model.Login;

            if (!ModelState.IsValid)
            {
                return View("Landing", model);
            }

            if (!Security.Authenticate(login.Username, login.Password))
            {
                ModelState.AddModelError("Username", "Username and/or password was incorrect.");

                return View("Landing", model);
            }

            Security.Login(login.Username);

            return GoToReferrer();
        }

      
        public ActionResult Logout()
        {
            Security.Logout();

            return RedirectToAction("Index", "Home");
        }
    }
}