using System.Threading.Tasks;
using BancoCarrefour.Application.Interfaces;
using BancoCarrefour.Domain.Commands;
using MediatR;

namespace BancoCarrefour.Application.Service
{
    public class TelegramAppService : ITelegramAppService
    {
        private readonly IMediator mediator;
        public TelegramAppService(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public Task<string> ExecuteCommandAsync(string command)
        {
            var response = mediator.Send(new TelegramBotCommand(command)).Result;

            return Task.FromResult(response.ToString());
        }
    }
}