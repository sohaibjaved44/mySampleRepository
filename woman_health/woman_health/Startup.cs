using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(woman_health.Startup))]
namespace woman_health
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
