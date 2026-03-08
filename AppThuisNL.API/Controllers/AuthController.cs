using AppThuisNL.Application.Services;
using Microsoft.AspNetCore.Mvc;
using AppThuisNL.Application.DTOs.Auth;


namespace AppThuisNL.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterUserDto dto)
        {
            var result = await _authService.RegisterUserAsync(dto);

            if (!result)
            {
                return BadRequest("User registration failed");
            }

            return Ok("User registered successfully");
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginUserDto dto)
        {
            var result = await _authService.LoginAsync(dto);

            if (result == null)
                return Unauthorized("Invalid credentials");

            return Ok(result);
        }

    }
}
