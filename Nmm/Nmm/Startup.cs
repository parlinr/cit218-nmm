using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nmm.Startup))]
namespace Nmm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
