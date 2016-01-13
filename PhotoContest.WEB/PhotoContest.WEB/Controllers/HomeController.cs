namespace PhotoContest.WEB.Controllers
{
    using System.Web.Mvc;
    using PhotoContest.Data.UnitOfWork;
    using AutoMapper;
    using PhotoContest.Models;
    using Models.ViewModels;
    using System.Collections.Generic;
    public class HomeController : BaseController
    {
        public HomeController(IPhotoContestData data) : base(data)
        {
        }

        public ActionResult Index()
        {
            var contests = Data.Contests.All();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AllUsers()
        {
            var users = Data.Users.All();

            var model = new List<UserQuickViewModel>();
            foreach (var user in users)
            {
                model.Add(Mapper.Map<User, UserQuickViewModel>(user));
            }

            return Json(model);
        }
    }
}