using System.Threading.Tasks;
using BancoCarrefour.Domain.Interfaces;

namespace BancoCarrefour.Domain.TelegramCommands
{
    public class CentralTelefonicaTC : ITelegramCommand
    {
        public string CommandName => "/centraltelefonica";

        public Task<string> Execute()
        {
            return Task.FromResult("Acesse: https://www.carrefoursolucoes.com.br/central-telefonica");
        }
    }
}