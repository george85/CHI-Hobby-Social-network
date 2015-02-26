using CHI_SocialNetwork.DataAccessLayer;
using CHI_SocialNetwork.DataAccessLayer.Interfaces;
using CHI_SocialNetwork.Models;
using CHI_SocialNetwork.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CHI_SocialNetwork.Controllers
{
    public class BaseController : Controller
    {
        protected IContext DataContext;
        public User CurrentUser { get; private set; }
        public IHobbyService Hobbies { get; private set; }
        public IUserService Users { get; private set; }
        public ISecurityService Security { get; private set; }
        public IUserProfileService Profiles { get; private set; }

        public BaseController()
        {
           
            DataContext = new Context();
            Users = new UserService(DataContext);
            Hobbies = new HobbyService(DataContext);
            Security = new SecurityService(Users);
            CurrentUser = Security.GetCurrentUser();
            Profiles = new UserProfileService(DataContext);
        }

        protected override void Dispose(bool disposing)
        {
            if (DataContext != null)
            {
                DataContext.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult GoToReferrer()
        {
            if (Request.UrlReferrer != null)
            {
                return Redirect(Request.UrlReferrer.AbsoluteUri);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}