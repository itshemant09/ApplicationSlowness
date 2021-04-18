using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ApplicationSlowness.Startup))]
namespace ApplicationSlowness
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
