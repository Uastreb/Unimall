using Unimall_TelegramBot.TelegramBot;

namespace Unimall_TelegramBot
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly ITelegramBotService _telegramBotService;

        public Worker(ILogger<Worker> logger, ITelegramBotService telegramBotService)
        {
            _logger = logger;
            _telegramBotService = telegramBotService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _telegramBotService.Start();


            if (stoppingToken.IsCancellationRequested)
            {
                _telegramBotService.Stop();
            }
        }
    }
}