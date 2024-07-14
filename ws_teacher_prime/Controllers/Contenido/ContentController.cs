using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WsTeacher_Prime.Controllers.Contenido
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContentController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateContent([FromBody] ContentModel model)
        {
            // Implementación del método create content
        }

        [HttpPut("{id}")]
        public IActionResult UpdateContent(int id, [FromBody] ContentModel model)
        {
            // Implementación del método update content
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteContent(int id)
        {
            // Implementación del método delete content
        }

        [HttpGet("{id}")]
        public IActionResult GetContentById(int id)
        {
            // Implementación del método get content by id
        }
    }

}
