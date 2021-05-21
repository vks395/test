using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication1GIT.Startup))]
namespace WebApplication1GIT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
