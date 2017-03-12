using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AndreaVitorianoCoach.Startup))]
namespace AndreaVitorianoCoach
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
