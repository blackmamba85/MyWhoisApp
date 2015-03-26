using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyWhoisApp.Startup))]
namespace MyWhoisApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
