using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_6567SAFinal.Startup))]
namespace _6567SAFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
