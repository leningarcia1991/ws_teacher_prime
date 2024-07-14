using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WsTeacher_Prime.Controllers.Seguridad
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudiesController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateEstudio([FromBody] EstudioModel model)
        {
            // Implementación del método create estudio
            return Ok(new { Message = "Estudio creado exitosamente" });
        }

        [HttpPut("{id}")]
        public IActionResult UpdateEstudio(int id, [FromBody] EstudioModel model)
        {
            // Implementación del método update estudio
            return Ok(new { Message = "Estudio actualizado exitosamente" });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEstudio(int id)
        {
            // Implementación del método delete estudio
            return Ok(new { Message = "Estudio eliminado exitosamente" });
        }

        // Método para obtener estudios un perfil por su ID
        [HttpGet("{id}")]
        public IActionResult GetEstudioByPerfilId(int id)
        {
            // Implementación del método para obtener el estudio por el id del perfil
            // Aquí se debería agregar la lógica para obtener los estudios del perfil de la base de datos
            var perfil = new EstudioModel(); 
            return Ok(perfil);
        }

    }


}
