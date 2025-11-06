using BarberShop.Core.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace BarberShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogosController : Controller
    {
        private readonly ICatalogoService _catalogoService;
        public CatalogosController(ICatalogoService catalogoService)
        {
            _catalogoService = catalogoService;
        }

        [HttpGet]
        public async Task<IActionResult> ObterCatalogos()
        {
            var catalogos = await _catalogoService.ObterTodosAsync();
            return Ok(catalogos);
        }

        [HttpGet]
        [Route("{catalogoId}/Itens")]
        public async Task<IActionResult> ObterItemsCatalogo([FromRoute]int catalogoId)
        {
            var catalogos = await _catalogoService.ObterItens(catalogoId);
            return Ok(catalogos);
        }
    }
}
