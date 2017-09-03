using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ITStepWebApp.Startup))]
namespace ITStepWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
