using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fuel_zad_domowe.Startup))]
namespace Fuel_zad_domowe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
