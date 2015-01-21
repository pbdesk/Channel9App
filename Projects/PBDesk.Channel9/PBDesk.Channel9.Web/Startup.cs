using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PBDesk.Channel9.Web.Startup))]
namespace PBDesk.Channel9.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
