using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(midterm.Startup))]
namespace midterm
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
