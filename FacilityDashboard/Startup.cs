using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FacilityDashboard.Startup))]
namespace FacilityDashboard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
