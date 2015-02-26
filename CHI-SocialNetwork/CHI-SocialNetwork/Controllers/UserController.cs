using CHI_SocialNetwork.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CHI_SocialNetwork.Controllers
{
    public class UserController : BaseController
    {
        //
        // GET: /User/

        public ActionResult Index(string username)
        {
            var user = Users.GetAllFor(username);

            if (user == null)
            {
                return new HttpNotFoundResult();
            }

            return View("UserProfile", new UserViewModel()
            {
                User = user,
                Hobbies = user.Hobbies
            });
        }

        public ActionResult Friends(string username)
        {
            var user = Users.GetAllFor(username);

            if (user == null)
            {
                return new HttpNotFoundResult();
            }

            return View("Friends", new FriendsViewModel()
            {
                User = user,
                Friends = user.Friends
            });
        }

    }
}
