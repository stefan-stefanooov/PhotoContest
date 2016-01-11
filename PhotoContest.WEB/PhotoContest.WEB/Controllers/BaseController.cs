namespace PhotoContest.WEB.Controllers
{
    using Data.UnitOfWork;
    using PhotoContest.Models;
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using System.Web.Routing;
    public class BaseController : Controller
    {
        public IPhotoContestData Data { get; private set; }
        public User UserProfile { get; private set; }

        public BaseController(IPhotoContestData data)
        {
            this.Data = data;
        }

        public BaseController(IPhotoContestData data, User user)
          : this(data)
        {
            this.UserProfile = user;
        }

        protected override IAsyncResult BeginExecute(RequestContext requestContext, AsyncCallback callback, object state)
        {
            if (requestContext.HttpContext.User.Identity.IsAuthenticated)
            {
                var username = requestContext.HttpContext.User.Identity.Name;
                var user = this.Data.Users.All().FirstOrDefault(u => u.UserName == username);
                this.UserProfile = user;
            }

            return base.BeginExecute(requestContext, callback, state);
        }
    }
}