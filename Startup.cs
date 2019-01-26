using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PDV_NATANIEL.Startup))]
namespace PDV_NATANIEL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
