using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DondeCargoNafta.Startup))]
namespace DondeCargoNafta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
