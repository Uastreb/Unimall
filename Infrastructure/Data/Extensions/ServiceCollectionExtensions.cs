using Core.Interfaces.Data.UOW;
using Data.UOW;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Data.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDataLayer(this IServiceCollection services, IConfiguration config)
        {
            services.AddLazyCache();
            services.AddUnitOfWork();
            services.AddDatabase(config);

            return services;
        }

        private static IServiceCollection AddUnitOfWork(this IServiceCollection services) =>
            services.AddScoped<IUnitOfWork, UnitOfWork>();

        private static IServiceCollection AddDatabase(
          this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<DataContext>(options => options.UseMySql(config.GetConnectionString("DefaultConnection"), new MySqlServerVersion(new Version(8, 0, 29))));

            return services;
        }
    }
}
