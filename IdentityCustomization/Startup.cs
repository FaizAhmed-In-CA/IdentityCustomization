using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityCustomization.Startup))]
namespace IdentityCustomization
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
