using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebCoreApp.Product.Services;

namespace WebCoreApp.Services
{
    public static class WebCoreAppServicesStartup
    {
        /// <summary>
        /// This method is used to register dependencies for this module.
        /// </summary>
        public static void RegisterWebCoreAppServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<ICourseService, CourseService>();
            services.AddTransient<IDepartmentService, DepartmentService>();
            
        }
    }
}
