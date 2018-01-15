using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Helix.Startup))]
namespace Helix
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
