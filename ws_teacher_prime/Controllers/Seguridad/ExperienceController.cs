using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WsTeacher_Prime.Controllers.Seguridad
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExperienceController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateExperience([FromBody] ExperienceModel model)
        {
            // Implementación del método create experiencia
            return Ok(new { Message = "Experiencia creada exitosamente" });
        }

        [HttpPut("{id}")]
        public IActionResult UpdateExperience(int id, [FromBody] ExperienceModel model)
        {
            // Implementación del método update experiencia
            return Ok(new { Message = "Experiencia actualizada exitosamente" });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteExperience(int id)
        {
            // Implementación del método delete experiencia
            return Ok(new { Message = "Experiencia eliminada exitosamente" });
        }

        // Método para obtener experiencia un perfil por su ID
        [HttpGet("{id}")]
        public IActionResult GetExperienceByPerfilId(int id)
        {
            // Implementación del método para obtener la experiencia por el id del perfil
            // Aquí se debería agregar la lógica para obtener la experiencia del perfil de la base de datos
            var perfil = new ExperienceModel();
            return Ok(perfil);
        }
    }

}
