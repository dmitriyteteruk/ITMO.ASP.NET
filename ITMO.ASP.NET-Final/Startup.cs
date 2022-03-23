using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ITMO.ASP.NET_Final.Startup))]
namespace ITMO.ASP.NET_Final
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
