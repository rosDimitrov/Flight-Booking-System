using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ABS.MVC.Startup))]
namespace ABS.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
