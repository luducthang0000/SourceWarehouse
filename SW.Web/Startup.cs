using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SW.Web.Startup))]
namespace SW.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
