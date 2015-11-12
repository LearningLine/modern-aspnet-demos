using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HackerSite.Startup))]
namespace HackerSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
