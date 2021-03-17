using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidio.Startup))]
namespace Vidio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
