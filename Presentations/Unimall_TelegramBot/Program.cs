using Unimall_TelegramBot;
using Unimall_TelegramBot.TelegramBot;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();

        services.AddScoped<ITelegramBotService, TelegramBotService>();
    })
    .Build();

await host.RunAsync();
