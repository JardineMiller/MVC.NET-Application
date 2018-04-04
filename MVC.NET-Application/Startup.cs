using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC.NET_Application.Startup))]
namespace MVC.NET_Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
