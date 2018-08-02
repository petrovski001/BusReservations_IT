using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BusReservations.Startup))]
namespace BusReservations
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
