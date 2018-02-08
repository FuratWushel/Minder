using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Minder.Startup))]
namespace Minder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
