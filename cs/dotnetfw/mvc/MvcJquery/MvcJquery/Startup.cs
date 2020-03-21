using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcJquery.Startup))]
namespace MvcJquery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
