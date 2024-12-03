using Microsoft.AspNetCore.Mvc;
using RealTimeCommunicationApp.DAL.Models.RequestModels;

namespace RealTimeCommunicationApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync(RegisterUserRequestModel request)
        {
            throw new NotImplementedException();
        }
    }
}
