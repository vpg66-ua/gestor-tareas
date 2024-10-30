using Microsoft.AspNetCore.Mvc;
using GestorTareas.Models;
using GestorTareas.Services;

namespace GestorTareas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] User user)
        {
            if (_authService.Register(user))
            {
                return Ok("Usuario registrado exitosamente.");
            }
            return BadRequest("Error al registrar el usuario.");
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] User user)
        {
            if (_authService.Login(user.Username, user.Password))
            {
                return Ok("Inicio de sesión exitoso.");
            }
            return Unauthorized("Credenciales inválidas.");
        }
    }
}