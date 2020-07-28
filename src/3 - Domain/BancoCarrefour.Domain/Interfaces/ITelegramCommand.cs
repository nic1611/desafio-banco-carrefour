using System.Threading.Tasks;

namespace BancoCarrefour.Domain.Interfaces
{
    public interface ITelegramCommand
    {
        string CommandName { get; }

        Task<string> Execute();
    }
}