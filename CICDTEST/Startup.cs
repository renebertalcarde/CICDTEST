using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CICDTEST.Startup))]
namespace CICDTEST
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
