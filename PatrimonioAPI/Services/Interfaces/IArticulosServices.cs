using Microsoft.AspNetCore.Mvc;
using PatrimonioAPI.Models.DTO;

namespace PatrimonioAPI.Services.Interfaces
{
    public interface IArticulosServices
    {
        IActionResult CrearArticulos(ArticulosDTO articulosDTO);
    }
}
