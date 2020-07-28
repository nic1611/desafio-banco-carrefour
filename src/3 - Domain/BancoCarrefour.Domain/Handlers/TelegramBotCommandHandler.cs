using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BancoCarrefour.Domain.Commands;
using BancoCarrefour.Domain.Interfaces;
using MediatR;

namespace BancoCarrefour.Domain.Handlers
{
    public class TelegramBotCommandHandler : IRequestHandler<TelegramBotCommand, String>
    {
        private readonly IEnumerable<ITelegramCommand> commands;
        public TelegramBotCommandHandler(IEnumerable<ITelegramCommand> commands)
        {
            this.commands = commands;
        }

        public Task<String> Handle(TelegramBotCommand request, CancellationToken cancellationToken)
        {
            var command = commands.FirstOrDefault(e => e.CommandName.Equals(request.command));

            if (command == null)
            {
                return Task.FromResult("Escolha um comando válido!");
            }

            var result = command.Execute();

            return Task.FromResult(result.Result);
        }
    }
}