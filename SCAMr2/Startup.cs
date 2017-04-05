using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SCAMr2.Startup))]
namespace SCAMr2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
