using Microsoft.AspNetCore.Mvc;
using WsTeacher_Prime.Models;
using WsTeacher_Prime.Services.Interfaces;

namespace WsTeacher_Prime.Controllers.Seguridad
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateUser([FromBody] UserModel model)
        {
            // Implementación del método create user
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            // Implementación del método get user
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, [FromBody] UserModel model)
        {
            // Implementación del método update user
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            // Implementación del método delete user
        }
    }

}
