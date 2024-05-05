using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeCarePro.Startup))]
namespace HomeCarePro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
