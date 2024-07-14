using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WsTeacher_Prime.Models;

namespace WsTeacher_Prime.Controllers.Administracion
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminUserController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            // Implementación del método get all users
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            // Implementación del método get user by id
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
