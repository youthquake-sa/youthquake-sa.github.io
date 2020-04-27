using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(youthquake.Startup))]
namespace youthquake
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
