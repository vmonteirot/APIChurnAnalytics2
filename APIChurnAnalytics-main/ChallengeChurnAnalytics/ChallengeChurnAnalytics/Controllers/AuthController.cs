
using ChallengeChurnAnalytics.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ChallengeChurnAnalytics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ExternalAuthService _authService;

        public AuthController(ExternalAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate(string token)
        {
            var result = await _authService.AuthenticateUserAsync(token);
            return Ok(result);
        }
    }
}
