using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WsTeacher_Prime.Controllers.Administracion
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminPermissionController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreatePermission([FromBody] PermissionModel model)
        {
            // Implementación del método create permission.
        }

        [HttpGet]
        public IActionResult GetAllPermissions()
        {
            // Implementación del método get all permissions.
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePermission(int id, [FromBody] PermissionModel model)
        {
            // Implementación del método update permission
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePermission(int id)
        {
            // Implementación del método delete permission
        }
    }

}
