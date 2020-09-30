using System;
using IdentityNetCore.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Identity;
using IdentityNetCore.Service;

namespace IdentityNetCore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // RB
            var conStr = Configuration["ConnectionStrings:Default"];
            services.AddDbContext<ApplicationDBContext>(o => o.UseSqlServer(conStr));

            // RB
            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDBContext>();

            // RB
            services.Configure<IdentityOptions>(options =>
            {
                // Password complexity options
                options.Password.RequiredLength = 3;
                options.Password.RequireDigit = true;
                options.Password.RequireNonAlphanumeric = true;
                
                // Lockout options
                options.Lockout.MaxFailedAccessAttempts = 3;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);

                // Require e-mail confirmation before allowing the user to sign in
                // This helps to deter robot account creations
                options.SignIn.RequireConfirmedEmail = true;
            });

            // RB: Configure additional options for cookie auth
            services.ConfigureApplicationCookie(option => {
                option.LoginPath = "/Identity/SignIn";
                option.AccessDeniedPath = "/Identity/AccessDenied";
            });

            // RB
            services.Configure<SmtpOptions>(Configuration.GetSection("SMTP"));

            // RB
            services.AddSingleton<IEmailSender, SmtpEmailSender>();

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            // RB: Add Authhentication middleware
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
