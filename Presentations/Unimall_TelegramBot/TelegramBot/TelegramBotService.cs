using Core.Features.Products.Commands.UpdateProductCountsFromGoogleDoc;
using MediatR;
using Microsoft.Extensions.Options;
using Shared.Configurations;
using Shared.Wrapper;
using System.Text;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.InputFiles;

namespace Unimall_TelegramBot.TelegramBot
{
    public class TelegramBotService : ITelegramBotService
    {
        private readonly ITelegramBotClient _tgClient;
        private CancellationTokenSource _tgClientCTS;
        private CancellationTokenSource _updateProductsCTS;

        private bool _isRunning = false;

        private readonly IServiceScopeFactory _serviceScopeFactory;
        private readonly TelegramBotConfiguration _telegramBotConfiguration;

        public TelegramBotService(IServiceScopeFactory serviceScopeFactory, IOptions<TelegramBotConfiguration> telegramBotConfiguration)
        {
            _serviceScopeFactory = serviceScopeFactory;
            _telegramBotConfiguration = telegramBotConfiguration.Value;

            _tgClient = new TelegramBotClient(_telegramBotConfiguration.Token);
        }

        public async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            // Некоторые действия
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(update));
            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {
                var message = update.Message;
                if (message.Text.ToLower() == "/start")
                {
                    await HandleStartCommand(botClient, message);
                    return;
                }

                if (message.Text.ToLower() == "/updateproducts")
                {
                    await HandleUpdateProductsCommand(botClient, message);
                    return;
                }

                if (message.Text.ToLower() == "/startupdatingproducts")
                {
                    await HandleStartUpdatingProductsCommand(botClient, message);
                    return;
                }

                if (message.Text.ToLower() == "/stopupdatingproducts")
                {
                    await HandleStopUpdatingProductsCommand(botClient, message);
                    return;
                }

                await botClient.SendTextMessageAsync(message.Chat, "Не понимаю тебя.");
            }
        }

        #region Tg bot commands

        private async Task HandleStartCommand(ITelegramBotClient botClient, Message message)
        {
            await botClient.SendTextMessageAsync(message.Chat, "Привет привет, еще один командир добавился.");
        }

        private async Task HandleUpdateProductsCommand(ITelegramBotClient botClient, Message message)
        {
            var updateProductsResult = await ExecuteScopeAsync(new UpdateProductCountsFromGoogleDocCommand());
            if (updateProductsResult.Succeeded)
            {
                await botClient.SendTextMessageAsync(message.Chat, "Наличие товаров обновлено без ошибок.");
                return;
            }
            else
            {
                var errorText = "Наличие товаров обновлено были ошибки:";
                foreach (var error in updateProductsResult.Messages)
                {
                    errorText += $"\n{error}";
                }

                await botClient.SendTextMessageAsync(message.Chat, errorText);
                return;
            }
        }

        private async Task HandleStartUpdatingProductsCommand(ITelegramBotClient botClient, Message message)
        {
            if (_updateProductsCTS != default && !_updateProductsCTS.IsCancellationRequested)
            {
                //Таска уже работает, просто возвращаем
                await botClient.SendTextMessageAsync(message.Chat, "Обновление товаров уже было запущено.");
                return;
            }
            else if (_updateProductsCTS != default && _updateProductsCTS.IsCancellationRequested)
            {
                //Таска в ожидании, токен отменен, регаем новый токен
                await botClient.SendTextMessageAsync(message.Chat, "Возобновил обновление товаров.");
                _updateProductsCTS = new CancellationTokenSource();
                return;
            }

            //Создаем задачу
            await botClient.SendTextMessageAsync(message.Chat, "Запустил обновление товаров.");
            _updateProductsCTS = new CancellationTokenSource();
            await Task.Factory.StartNew(async () =>
            {
                while (!_updateProductsCTS.Token.IsCancellationRequested)
                {
                    await HandleUpdateProductsCommand(botClient, message);
                    await Task.Delay(TimeSpan.FromMinutes(1));
                }
            }, _updateProductsCTS.Token);
        }

        private async Task HandleStopUpdatingProductsCommand(ITelegramBotClient botClient, Message message)
        {
            if (_updateProductsCTS != default && !_updateProductsCTS.IsCancellationRequested)
            {
                _updateProductsCTS.Cancel();
                await botClient.SendTextMessageAsync(message.Chat, "Остановил обновление товаров.");
                return;
            }

            await botClient.SendTextMessageAsync(message.Chat, "Обновление товаров уже было остановлено.");

        }

        #endregion

        public async Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            var errorFileStream = new MemoryStream(Encoding.UTF8.GetBytes(exception.ToString()));

            InputOnlineFile iof = new InputOnlineFile(errorFileStream, "error.txt");
            await botClient.SendDocumentAsync(new ChatId(577776091), iof, caption: "Произошла ошибка, вот лог.");
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


        public async Task<IResult> ExecuteScopeAsync(IRequest<IResult> request)
        {
            using (var scope = _serviceScopeFactory.CreateScope())
            {
                try
                {
                    var mediator = scope.ServiceProvider.GetService<IMediator>();

                    var result = await mediator.Send(request);

                    return result;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }
    }
}
