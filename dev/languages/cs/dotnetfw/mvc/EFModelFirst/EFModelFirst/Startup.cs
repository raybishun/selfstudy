using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EFModelFirst.Startup))]
namespace EFModelFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
