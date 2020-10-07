using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace TicTacToe
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // RB Added MVC Middleware
            services.AddControllersWithViews();

            // RB Added Razor Middleware
            services.AddRazorPages();
            
            // RB Added Routing Middleware
            services.AddRouting();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // RB
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            // RB
            app.UseStaticFiles();

            // RB
            var routeBuilder = new RouteBuilder(app);

            // RB
            //routeBuilder.MapGet("CreateUser", context =>
            //{
            //    var firstName = context.Request.Query["firstName"];
            //    var lastName = context.Request.Query["lastName"];
            //    var email = context.Request.Query["email"];
            //    var password = context.Request.Query["password"];
            //    var userService = context.RequestServices.GetService<IUserService>();
            //    userService.RegisterUser(new UserModel { FirstName = firstName, LastName = lastName, Email = email, Password = password });
            //    return context.Response.WriteAsync($"User {firstName} {lastName} has been successfully created.");
            //});

            // RB
            var newUserRoutes = routeBuilder.Build();
            // RB
            app.UseRouter(newUserRoutes);
            // RB
            app.UseCookiePolicy();


            app.UseRouting();

            // RB
            app.UseAuthorization();

            // RB
            // app.UseCommunicationMiddleware();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });

            // RB
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //        name: "default",
            //        pattern: "{controller=Home}/{action=Index}/{id?}");
            //    endpoints.MapRazorPages();
            //});

            // RB
            app.UseStatusCodePages("text/plain", "HTTP Error - Status Code: {0}");
        }
    }
}
