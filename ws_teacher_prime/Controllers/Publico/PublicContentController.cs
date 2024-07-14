using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WsTeacher_Prime.Controllers.Publico
{
    [ApiController]
    [Route("api/[controller]")]
    public class PublicContentController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllContent()
        {
            // Implementación del método get all content
        }

        [HttpGet("{id}")]
        public IActionResult GetContentById(int id)
        {
            // Implementación del método get content by id
        }
    }

}
