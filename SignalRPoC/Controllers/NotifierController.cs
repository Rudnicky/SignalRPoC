using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SignalRPoC.Services.SignalRHubService;

namespace SignalRPoC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotifierController : ControllerBase
    {
        private readonly IHubService _hubService;
        
        public NotifierController(IHubService hubService)
        {
            _hubService = hubService;
        }
        
        [HttpGet]
        public async Task Logout()
        {
            await _hubService.LogoutUsers();
        }
    }
}