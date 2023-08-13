using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyCompanyApp.Service;

namespace MyCompanyApp
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = (IConfigurationRoot)configuration;
        public void ConfigureServices(IServiceCollection services)
        {
            // Config.cs connecting from appsettings.json
            Configuration.Bind("Project", new Config());

            //add controllers and views support (MVC)
            services.AddControllersWithViews()
                // use compatibility with ASP.NET Core 3.0
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //!!! middleware registration order (is very important) !!! 

            // In development process we need to get detailed informatio about errors
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();
            
            app.UseRouting();

            // Application static files support connection(css, js, etc.)
            app.UseStaticFiles();

            // register routes we need (endpoints)
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
