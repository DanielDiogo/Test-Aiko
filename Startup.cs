using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Test_Aiko.Data;
using Test_Aiko.Interfaces;
using Test_Aiko.Repositories;

namespace Test_Aiko
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            // Configure database
            var connectionString = Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite(connectionString));
            services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddControllers();
            services.AddScoped<ILineRepository, LineRepository>();
            services.AddScoped<IStopRepository, StopRepository>();
            services.AddScoped<IVehiclePositionRepository, VehiclePositionRepository>();
            services.AddScoped<IVehicleRepository, VehicleRepository>();
            // Configure Identity
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            // Add Razor Pages
            services.AddRazorPages();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllerRoute(
                    name: "apiRoute",
                    pattern: "api/{controller}/{action}/{id?}"
                );
            });
        }
    }
}
