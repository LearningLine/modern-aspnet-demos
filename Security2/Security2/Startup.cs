using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Security2.Startup))]
namespace Security2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
