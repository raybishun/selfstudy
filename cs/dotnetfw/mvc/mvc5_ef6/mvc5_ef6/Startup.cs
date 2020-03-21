using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc5_ef6.Startup))]
namespace mvc5_ef6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
