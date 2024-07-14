using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WsTeacher_Prime.Controllers.Publico
{
    [ApiController]
    [Route("api/[controller]")]
    public class PublicProfileController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllProfiles()
        {
            // Implementación del método get all profiles
        }

        [HttpGet("{id}")]
        public IActionResult GetProfileById(int id)
        {
            // Implementación del método get profile by id
        }
    }

}
