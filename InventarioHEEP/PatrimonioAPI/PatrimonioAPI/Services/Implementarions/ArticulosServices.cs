using Microsoft.AspNetCore.Mvc;
using PatrimonioAPI.Models;
using PatrimonioAPI.Models.DTO;
using PatrimonioAPI.Services.Interfaces;

namespace PatrimonioAPI.Services.Implementarions
{
    public class ArticulosServices : IArticulosServices
    {
        private readonly InventarioDBContext _context;

        public ArticulosServices(InventarioDBContext context)
        {
            _context = context;
        }

        IActionResult IArticulosServices.CrearArticulos(ArticulosDTO articulosDTO)
        {
            if (articulosDTO == null)
            {
                return new BadRequestObjectResult("Los datos de los artículos no pueden ser nulos.");
            }

            var articulo = new Articulo
            {
                Descripcion = articulosDTO.Descripcion,
                Cantidad = articulosDTO.Cantidad
            };

            _context.Articulos.Add(articulo);
            _context.SaveChanges();

            return new OkObjectResult(new { Id = articulo.Id, Descripcion = articulo.Descripcion, Cantidad = articulo.Cantidad });
        }
               
    }
}
