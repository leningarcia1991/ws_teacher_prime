using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WsTeacher_Prime.Controllers.Contenido
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommentController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateComment([FromBody] CommentModel model)
        {
            // Implementación del método create comment
        }

        [HttpPut("{id}")]
        public IActionResult UpdateComment(int id, [FromBody] CommentModel model)
        {
            // Implementación del método update comment
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteComment(int id)
        {
            // Implementación del método delete comment
        }

        [HttpGet("content/{contentId}")]
        public IActionResult GetCommentsByContentId(int contentId)
        {
            // Implementación del método get comments by content id
        }
    }

}
