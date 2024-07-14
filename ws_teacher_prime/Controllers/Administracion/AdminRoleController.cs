using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WsTeacher_Prime.Controllers.Administracion
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminRoleController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateRole([FromBody] RoleModel model)
        {
            // Implementación del método create role
        }

        [HttpGet]
        public IActionResult GetAllRoles()
        {
            // Implementación del método get all roles
        }

        [HttpPut("{id}")]
        public IActionResult UpdateRole(int id, [FromBody] RoleModel model)
        {
            // Implementación del método update role
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRole(int id)
        {
            // Implementación del método delete role
        }
    }

}
