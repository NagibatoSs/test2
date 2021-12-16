using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using REALtor.Data;
using REALtor.Data.Interfaces;
using REALtor.Data.Repository;

namespace REALtor
{
    public class Startup
    {
        private IConfigurationRoot _confString;
        public Startup(IHostingEnvironment host)
        {
            _confString = new ConfigurationBuilder().SetBasePath(host.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DbContent>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
            services.AddTransient<IAllHouses, HouseRepository>();
            services.AddMvc();
            services.AddRazorPages();
            services.AddMvc(option => option.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
                app.UseMvc(routes => {
                    routes.MapRoute(
                        name: "default",
                        template: "{controller=Houses}/{action=ListAllHouses}"
                    );
                });
                using (var scope = app.ApplicationServices.CreateScope())
            {
                DbContent content = scope.ServiceProvider.GetRequiredService<DbContent>();
                DbObjects.Initial(content);
            }
        }
    }
}
