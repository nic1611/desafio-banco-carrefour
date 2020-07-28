using System.Threading.Tasks;
using BancoCarrefour.Domain.Interfaces;

namespace BancoCarrefour.Domain.TelegramCommands
{
    public class OuvidoriaTC : ITelegramCommand
    {
        public string CommandName => "/ouvidoria";

        public Task<string> Execute()
        {
            return Task.FromResult("Acesse: https://www.carrefoursolucoes.com.br/ouvidoria");
        }
    }
}