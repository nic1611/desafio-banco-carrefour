using System.Threading.Tasks;
using BancoCarrefour.Domain.Interfaces;

namespace BancoCarrefour.Domain.TelegramCommands
{
    public class FaleConoscoTC : ITelegramCommand
    {
        public string CommandName => "/faleconosco";

        public Task<string> Execute()
        {
            return Task.FromResult("Acesse: https://www.carrefoursolucoes.com.br/fale-conosco");
        }
    }
}