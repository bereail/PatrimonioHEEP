using Microsoft.AspNetCore.Mvc;
using PatrimonioAPI.Models.DTO;
using PatrimonioAPI.Services.Interfaces;

namespace PatrimonioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticulosController : ControllerBase
    {
        private readonly IArticulosServices _articulosServices;

        public ArticulosController(IArticulosServices articulosServices)
        {
            _articulosServices = articulosServices;
        }

        [HttpPost("crearArticulos")]
        public IActionResult CrearArticulos([FromBody] ArticulosDTO articulosDTO)
        {
            var result = _articulosServices.CrearArticulos(articulosDTO);
            return result;
        }
    }
}
