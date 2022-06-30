using Core.Interfaces.Data.UOW;
using Data.UOW;
using Microsoft.Extensions.DependencyInjection;

namespace Data.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddUnitOfWork(this IServiceCollection services) =>
            services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
}
