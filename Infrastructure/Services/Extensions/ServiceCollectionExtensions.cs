using Core.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;
using Services.GoogleSheet;

namespace Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddServicesLayer(this IServiceCollection services)
        {
            services.AddScoped<IGoogleSheetsService, GoogleSheetsService>();
        }
    }
}
