using Telegram.Bot;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Types;

namespace Background_Worker.TelegramBot
{
    public class TelegramBotService : ITelegramBotService
    {
        private readonly ITelegramBotClient _tgClient = new TelegramBotClient("5466607700:AAHrC4I8pr2AaKY9A65UMrnSB90K4OzB0iE");
        private CancellationTokenSource _tgClientCTS;

        private bool _isRunning = false;

        public async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            // Некоторые действия
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(update));
            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {
                var message = update.Message;
                if (message.Text.ToLower() == "/start")
                {
                    await botClient.SendTextMessageAsync(message.Chat, "Добро пожаловать на борт, добрый путник!");
                    return;
                }
                await botClient.SendTextMessageAsync(message.Chat, "Привет-привет!!");
            }
        }

        public async Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            // Некоторые действия
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(exception));
        }

        public void Start()
        {
            if (!_isRunning)
            {
                _tgClientCTS = new CancellationTokenSource();
                var tgClientCT = _tgClientCTS.Token;
                var receiverOptions = new ReceiverOptions
                {
                    AllowedUpdates = { }, // receive all update types
                };
                _tgClient.StartReceiving(
                    HandleUpdateAsync,
                    HandleErrorAsync,
                    receiverOptions,
                    tgClientCT
                );

                _isRunning = true;
            }
        }

        public void Stop()
        {
            _tgClientCTS.Cancel();
            _isRunning = false;
        }
    }
}
