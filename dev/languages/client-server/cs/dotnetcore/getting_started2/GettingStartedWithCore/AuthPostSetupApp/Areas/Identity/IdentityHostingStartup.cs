using System;
using AuthPostSetupApp.Areas.Identity.Data;
using AuthPostSetupApp.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(AuthPostSetupApp.Areas.Identity.IdentityHostingStartup))]
namespace AuthPostSetupApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AuthPostSetupAppContext>(options =>
                    options.UseSqlite(
                        context.Configuration.GetConnectionString("AuthPostSetupAppContextConnection")));

                services.AddDefaultIdentity<AuthPostSetupAppUser>()
                    .AddEntityFrameworkStores<AuthPostSetupAppContext>();
            });
        }
    }
}