using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace WsTeacher_Prime.Controllers.Contenido
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReactionController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateReaction([FromBody] ReactionModel model)
        {
            // Implementación del método create reaction
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteReaction(int id)
        {
            // Implementación del método delete reaction
        }

        [HttpGet("content/{contentId}")]
        public IActionResult GetReactionsByContentId(int contentId)
        {
            // Implementación del método get reactions by content id
        }
    }

}
