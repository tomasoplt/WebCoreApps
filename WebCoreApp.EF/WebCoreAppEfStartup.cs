using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebCoreApp.EF.Data;

namespace WebCoreApp.Services
{
    public static class WebCoreAppEfStartup
    {
        /// <summary>
        /// This method is used to register dependencies for this module.
        /// </summary>
        public static void RegisterWebCoreEntityFrameworkServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<DbContext, WebCoreContext>();
        }
    }
}
