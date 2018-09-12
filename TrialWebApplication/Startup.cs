using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrialWebApplication.Startup))]
namespace TrialWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
