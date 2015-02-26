using CHI_SocialNetwork.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CHI_SocialNetwork.Controllers
{
    public class HomeController:BaseController
    {
        public HomeController() : base() { }

        public ActionResult Index()
        {
            if (!Security.IsAuthenticated)
            {
                return View("Landing", new LoginSignupViewModel());
            }

            var timeline = Hobbies.GetHobbiesFor(Security.UserId).ToArray();

            return View(timeline);
        }

       

       

        public ActionResult Profiles()
        {
            var users = Users.All(true);

            return View(users);
        }


        [HttpGet]
        [ChildActionOnly]
        public ActionResult Create()
        {
            return PartialView("_CreateRibbitPartial", new CreateHobbyViewModel());
        }

        [HttpPost]
        [ChildActionOnly]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateHobbyViewModel model)
        {
            if (ModelState.IsValid)
            {
                Hobbies.Create(Security.UserId, model.Name);

                Response.Redirect("/");
            }

            return PartialView("_CreateRibbitPartial", model);
        }

    }
}
