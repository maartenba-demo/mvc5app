using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AcmeCompany.Portal.Startup))]
namespace AcmeCompany.Portal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
