using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WsTeacher_Prime.Controllers.Seguridad
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExperienceController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateExperiencia([FromBody] ExperienciaModel model)
        {
            // Implementación del método create experiencia
            return Ok(new { Message = "Experiencia creada exitosamente" });
        }

        [HttpPut("{id}")]
        public IActionResult UpdateExperiencia(int id, [FromBody] ExperienciaModel model)
        {
            // Implementación del método update experiencia
            return Ok(new { Message = "Experiencia actualizada exitosamente" });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteExperiencia(int id)
        {
            // Implementación del método delete experiencia
            return Ok(new { Message = "Experiencia eliminada exitosamente" });
        }

        // Método para obtener experiencia un perfil por su ID
        [HttpGet("{id}")]
        public IActionResult GetExperienciaByPerfilId(int id)
        {
            // Implementación del método para obtener la experiencia por el id del perfil
            // Aquí se debería agregar la lógica para obtener la experiencia del perfil de la base de datos
            var perfil = new ExperienciaModel();
            return Ok(perfil);
        }
    }

}
