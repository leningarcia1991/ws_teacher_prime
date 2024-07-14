using Microsoft.AspNetCore.Mvc;
using WsTeacher_Prime.Models;
using WsTeacher_Prime.Services.Interfaces;

namespace WsTeacher_Prime.Controllers.Seguridad
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel loginModel)
        {
            var token = await _authService.LoginAsync(loginModel);

            if (token == null)
                return Unauthorized(new { message = "Username or password is incorrect" });

            return Ok(new { token });
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel registerModel)
        {
            var result = await _authService.RegisterAsync(registerModel);

            if (!result)
                return BadRequest(new { message = "User registration failed" });

            return Ok(new { message = "User registered successfully" });
        }

        [HttpPost("refresh")]
        public async Task<IActionResult> RefreshToken([FromBody] TokenModel tokenModel)
        {
            var newToken = await _authService.RefreshTokenAsync(tokenModel.Token);

            if (newToken == null)
                return Unauthorized(new { message = "Invalid token" });

            return Ok(new { token = newToken });
        }
    }
}
