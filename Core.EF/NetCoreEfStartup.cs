using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Net.Core.EF
{
    public static class NetCoreEfStartup
    {
        /// <summary>
        /// This method is used to register dependencies for this module.
        /// </summary>
        public static void RegisterNetCoreEfSServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));
        }
    }
}
