using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GAG_101.Startup))]
namespace GAG_101
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
