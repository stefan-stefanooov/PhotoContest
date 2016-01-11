﻿namespace PhotoContest.WEB.Controllers
{
    using System.Web.Mvc;
    using PhotoContest.Data.UnitOfWork;

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
    }
}