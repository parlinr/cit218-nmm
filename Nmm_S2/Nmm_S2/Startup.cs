using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nmm_S2.Startup))]
namespace Nmm_S2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
