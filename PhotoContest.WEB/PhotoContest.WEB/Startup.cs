using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhotoContest.WEB.Startup))]
namespace PhotoContest.WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
