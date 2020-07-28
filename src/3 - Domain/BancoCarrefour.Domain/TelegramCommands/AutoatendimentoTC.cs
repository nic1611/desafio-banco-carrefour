using System.Threading.Tasks;
using BancoCarrefour.Domain.Interfaces;

namespace BancoCarrefour.Domain.TelegramCommands
{
    public class AutoatendimentoTC : ITelegramCommand
    {
        public string CommandName => "/autoatendimento";

        public Task<string> Execute()
        {
            return Task.FromResult("Acesse: https://www.carrefoursolucoes.com.br/auto-atendimento");
        }
    }
}