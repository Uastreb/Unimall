using Core.Extensions;
using Data.Extensions;
using Services.Extensions;
using Unimall_TelegramBot;
using Unimall_TelegramBot.Extensions;
using Unimall_TelegramBot.TelegramBot;


public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }


    public static IHostBuilder CreateHostBuilder(string[] args)
    {
        var hostBuilder = Host.CreateDefaultBuilder(args)
            .ConfigureServices((hostContext, services) =>
            {
                var configuration = hostContext.Configuration;

                //Регистрируем конфиги из AppSettings
                services.GetGoogleSheetsSettings(configuration);
                services.GetApplicationSettings(configuration);
                services.GetTelegramBotSettings(configuration);

                //Application-Core
                services.AddApplicationLayer();

                //Infrastructure-Data
                services.AddDataLayer(configuration);

                //Infrastructure-Services
                services.AddServicesLayer();

                services.AddSingleton<ITelegramBotService, TelegramBotService>();

                services.AddHostedService<Worker>();
            });
        
        return hostBuilder;
    }
}
