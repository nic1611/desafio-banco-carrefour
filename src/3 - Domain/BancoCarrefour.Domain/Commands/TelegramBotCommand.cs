using System;
using MediatR;

namespace BancoCarrefour.Domain.Commands
{
    public class TelegramBotCommand : IRequest<String>
    {
        public TelegramBotCommand(string command)
        {
            this.command = command;
        }
        public TelegramBotCommand()
        { }

        public string command { get; }
    }
}