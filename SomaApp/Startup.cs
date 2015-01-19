using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SomaApp.Startup))]
namespace SomaApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
