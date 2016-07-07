using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DefaultMVC.Startup))]
namespace DefaultMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
