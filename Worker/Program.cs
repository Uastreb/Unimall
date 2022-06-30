using Background_Worker;
using Background_Worker.TelegramBot;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();

        services.AddScoped<ITelegramBotService, TelegramBotService>();
    })
    .Build();

await host.RunAsync();
