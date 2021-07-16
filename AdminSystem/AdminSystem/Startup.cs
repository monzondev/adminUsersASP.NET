using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdminSystem.Startup))]
namespace AdminSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
