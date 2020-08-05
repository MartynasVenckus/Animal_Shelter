using Microsoft.AspNetCore.Mvc;
using Šitie.Dtos;
using Šitie.Services.Interfaces;

namespace Šitie.Controllers
{
    [Route("auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        public IActionResult Login([FromBody] LoginDto login)
        {
            IActionResult response = Unauthorized();
            var user = _authService.AuthenticateUser(login);
            if (user != null)
            {
                var tokenString = _authService.GenerateToken(user);
                response = Ok(new { token = tokenString });
            }
            return response;
        }
    }
}
