using System.Threading.Tasks;

namespace BancoCarrefour.Application.Interfaces
{
    public interface ITelegramAppService
    {
        Task<string> ExecuteCommandAsync(string command);
    }
}