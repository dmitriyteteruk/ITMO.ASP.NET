using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ITMO.ASP.NET_Practice_MVC_05_08.Startup))]
namespace ITMO.ASP.NET_Practice_MVC_05_08
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
