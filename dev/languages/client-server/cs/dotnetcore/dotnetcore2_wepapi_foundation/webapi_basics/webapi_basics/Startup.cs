using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using webapi_basics.Data;

namespace webapi_basics
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
            // RB Only returns data as JSON (the default)
            services.AddMvc();

            // RB Return data as XML
            // RB services.AddMvc().AddXmlSerializerFormatters();

            // RB
            services.AddDbContext<ProductsDbContext>(option => option.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProductsDb"));

            // RB
            //services.AddDbContext<ProductsDbContext>(option => 
            //    option.UseSqlServer(Configuration.GetConnectionString("ProductDbContext")));

            // RB
            services.AddSwaggerGen(c => c.SwaggerDoc(
                "v1", new Microsoft.OpenApi.Models.OpenApiInfo() { Title = "Products API", Version = "v1" }));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ProductsDbContext productsDbContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            // RB: If not found, create the DB
            productsDbContext.Database.EnsureCreated();

            // RB
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API for Projects"));

        }
    }
}