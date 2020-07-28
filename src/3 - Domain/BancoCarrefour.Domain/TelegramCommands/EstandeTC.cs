using System.Threading.Tasks;
using BancoCarrefour.Domain.Interfaces;

namespace BancoCarrefour.Domain.TelegramCommands
{
    public class EstandeTC : ITelegramCommand
    {
        public string CommandName => "/estande";

        public Task<string> Execute()
        {
            return Task.FromResult("Acesse: https://www.carrefoursolucoes.com.br/estande-nas-lojas");
        }
    }
}