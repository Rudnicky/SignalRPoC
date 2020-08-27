using System.Threading.Tasks;

namespace SignalRPoC.Services.SignalRHubService
{
    public interface IHubService
    {
        Task LogoutUsers();
        Task SendMessage(string message);
    }
}