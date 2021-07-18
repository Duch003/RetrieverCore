using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Databases.RetrieverCore.LocalDatabase.Context;
using Databases.RetrieverCore.MasterDatabase.Context;
using RetrieverCore.Repositories.Interfaces;
using RetrieverCore.Repositories.Local;
using System.Reflection;
using Databases.RetrieverCore.LocalDatabase;

namespace RetrieverCore.App
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
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        private void RegisterRepositories(IServiceCollection services)
        {
            services.AddEntityFrameworkSqlite().AddDbContext<LocalDatabaseContext>(x =>
            {
                x.UseSqlite("Filename=LocalDatabase.db", options =>
                {
                    options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
                });
            });
            services.AddEntityFrameworkSqlServer().AddDbContext<MasterDatabaseContext>(x => 
            {
                x.UseSqlServer(Configuration.GetConnectionString("Master"));
            });
            services.AddScoped(typeof(IGenericDatabaseRepository<>), typeof(GenericDatabaseRepository<>));
            services.AddScoped< IGenericComponentRepository, GenericComponentRepository>();

            services.AddScoped<IExtendedNetworkInterfaceComponentRepository, ExtendedNetworkInterfaceComponentRepository>();
        }
    }
}
