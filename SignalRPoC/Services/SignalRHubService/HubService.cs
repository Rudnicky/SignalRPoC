using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using SignalRPoC.Utils;

namespace SignalRPoC.Services.SignalRHubService
{
    // You can send messages thru SendAsync or InvokeAsync (the difference is the InvokeAsync returns some success/failed response).
    public class HubService : Hub, IHubService
    {
        private IHubContext<HubService> _context;

        public HubService(IHubContext<HubService> context)
        {
            _context = context;
        }
        
        public async Task LogoutUsers()
        {
            await _context.Clients.All.SendAsync(Messages.LogoutMessage);
        }

        public async Task SendMessage(string message)
        {
            await _context.Clients.All.SendAsync("Test Message");
        }
    }
}