using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PetVetApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controller : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
             return Ok("Esta tudo certo");
        }
    }
}
