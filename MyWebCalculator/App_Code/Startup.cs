using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyWebCalculator.Startup))]
namespace MyWebCalculator
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
