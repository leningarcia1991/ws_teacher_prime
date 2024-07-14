using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WsTeacher_Prime.Controllers.Seguridad
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudiesController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateStudies([FromBody] StudiesModel model)
        {
            // Implementación del método create estudio
            return Ok(new { Message = "Estudio creado exitosamente" });
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudies(int id, [FromBody] StudiesModel model)
        {
            // Implementación del método update estudio
            return Ok(new { Message = "Estudio actualizado exitosamente" });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudies(int id)
        {
            // Implementación del método delete estudio
            return Ok(new { Message = "Estudio eliminado exitosamente" });
        }

        // Método para obtener estudios un perfil por su ID
        [HttpGet("{id}")]
        public IActionResult GetStudiesByPerfilId(int id)
        {
            // Implementación del método para obtener el estudio por el id del perfil
            // Aquí se debería agregar la lógica para obtener los estudios del perfil de la base de datos
            var perfil = new StudiesModel(); 
            return Ok(perfil);
        }

    }


}
