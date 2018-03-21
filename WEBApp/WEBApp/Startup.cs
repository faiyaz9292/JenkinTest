using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WEBApp.Startup))]
namespace WEBApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
