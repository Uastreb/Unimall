using Background_Worker.TelegramBot;
using Telegram.Bot;

namespace Background_Worker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        private readonly ITelegramBotService _tgService;

        public Worker(ILogger<Worker> logger, ITelegramBotService tgService)
        {
            _logger = logger;
            _tgService = tgService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {

            _tgService.Start();

            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }

            if (stoppingToken.IsCancellationRequested)
            {
                _tgService.Stop();
            }
        }
    }
}