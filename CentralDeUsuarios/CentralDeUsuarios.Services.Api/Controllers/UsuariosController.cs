using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CentralDeUsuarios.Services.Api.Controllers
{
    [Route("api/[controller]")] //Mapea a rota
    [ApiController]
    public class UsuariosController : ControllerBase
    {

        [HttpPost]
        public IActionResult Post ()
        {
        
            return Ok();
        
        }

    }
}
