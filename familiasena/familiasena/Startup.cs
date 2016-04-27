using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(familiasena.Startup))]
namespace familiasena
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
