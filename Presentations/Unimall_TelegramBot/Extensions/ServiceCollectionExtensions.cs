using Shared.Configurations;

namespace Unimall_TelegramBot.Extensions
{
    public static class ServiceCollectionExtensions
    {
        internal static AppConfiguration GetApplicationSettings(
           this IServiceCollection services, IConfiguration config)
        {
            var applicationSettingsConfiguration = config.GetSection(nameof(AppConfiguration));
            services.Configure<AppConfiguration>(applicationSettingsConfiguration);

            return applicationSettingsConfiguration.Get<AppConfiguration>();
        }

        internal static GoogleSheetsConfiguration GetGoogleSheetsSettings(
           this IServiceCollection services, IConfiguration config)
        {
            var applicationSettingsConfiguration = config.GetSection(nameof(GoogleSheetsConfiguration));
            services.Configure<GoogleSheetsConfiguration>(applicationSettingsConfiguration);

            return applicationSettingsConfiguration.Get<GoogleSheetsConfiguration>();
        }

        internal static TelegramBotConfiguration GetTelegramBotSettings(
           this IServiceCollection services, IConfiguration config)
        {
            var applicationSettingsConfiguration = config.GetSection(nameof(TelegramBotConfiguration));
            services.Configure<TelegramBotConfiguration>(applicationSettingsConfiguration);

            return applicationSettingsConfiguration.Get<TelegramBotConfiguration>();
        }
    }
}
