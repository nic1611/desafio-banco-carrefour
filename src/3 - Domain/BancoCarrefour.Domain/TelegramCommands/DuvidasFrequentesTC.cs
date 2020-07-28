using System.Threading.Tasks;
using BancoCarrefour.Domain.Interfaces;

namespace BancoCarrefour.Domain.TelegramCommands
{
    public class DuvidasFrequentesTC : ITelegramCommand
    {
        public string CommandName => "/duvidasfrequentes";

        public Task<string> Execute()
        {
            return Task.FromResult("Acesse: https://www.carrefoursolucoes.com.br/duvidas-frequentes");
        }
    }
}