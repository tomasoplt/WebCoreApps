using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Net.Core.EF;
using WebCoreApp.EF.Data;
using WebCoreApp.Infrastructure.Configuration;
using WebCoreApp.Services;

namespace WebCoreAppMvc
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

            services.AddHttpContextAccessor();
            services.AddDbContext<WebCoreContext>(options => options.UseSqlServer(Configuration.GetConnectionString("WebCoreAppContext")));
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            // Bind the settings instance as a singleton and expose it as an options type (IOptions<SmartSettings>)
            services.Configure<SmartSettings>(Configuration.GetSection("SmartAdmin"));

            services.AddKendo();

            // configures anti-forgery service to pick the anti-forgery token from request headers rather than request body. 
            // This is required because we will be issuing Ajax requests to the razor page and there won't be any full page post-backs.
            services.AddAntiforgery(options => options.HeaderName = "ANTI-XSRF-TOKEN");

            // Register Assembly Services
            services.RegisterNetCoreEfSServices(Configuration);
            services.RegisterWebCoreEntityFrameworkServices(Configuration);
            services.RegisterWebCoreAppServices(Configuration);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
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
            loggerFactory.AddLog4Net();
            app.UseRouting();
            
            // Call UseSession after UseRouting and before UseEndpoints
            app.UseSession();

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
