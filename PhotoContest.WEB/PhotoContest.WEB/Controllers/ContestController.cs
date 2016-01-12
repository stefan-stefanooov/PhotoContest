using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhotoContest.Data.UnitOfWork;
using PhotoContest.WEB.Models.BindModels;

namespace PhotoContest.WEB.Controllers
{
    public class ContestController : BaseController
    {
        public ContestController(IPhotoContestData data) : base(data)
        {
        }


        [HttpGet]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(NewContestBindModel model)
        {
            return View();
        }
    }
}