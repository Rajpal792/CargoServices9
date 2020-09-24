using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CargoServices.Startup))]
namespace CargoServices
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
