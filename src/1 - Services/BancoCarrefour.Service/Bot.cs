using System;
using BancoCarrefour.Application.Interfaces;
using Microsoft.Extensions.Configuration;
using Telegram.Bot;

namespace BancoCarrefour.Service
{
    public class Bot : IDisposable
    {
        private TelegramBotClient telegram;
        private readonly ITelegramAppService service;

        public Bot(IConfiguration configuration, ITelegramAppService service)
        {
            this.telegram = new TelegramBotClient(configuration["TelegramKey"]);
            this.telegram.OnMessage += Bot_onMessage;
            this.telegram.StartReceiving();
            this.service = service;
        }
        
        private void Bot_onMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            if (e.Message.Text == null)
            {
                telegram.SendTextMessageAsync(e.Message.Chat.Id, "");
            }
            else
            {
                telegram.SendTextMessageAsync(e.Message.Chat.Id, service.ExecuteCommandAsync(e.Message.Text).Result, replyToMessageId: e.Message.MessageId);
            }
        }

        public void Dispose()
        {
            this.telegram.StopReceiving();
        }
    }
}