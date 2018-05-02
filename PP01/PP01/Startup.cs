using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PP01.Startup))]
namespace PP01
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
