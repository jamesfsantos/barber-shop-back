using BarberShop.BLL;
using BarberShop.Core.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace BarberShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GaleriasController : Controller
    {
        private readonly IGaleriaService _galeriaService;
        public GaleriasController(IGaleriaService galeriaService)
        {
            _galeriaService = galeriaService;
        }

        [HttpGet]
        public async Task<IActionResult> ObterGalerias()
        {
            var galerias = await _galeriaService.ObterTodosAsync();
            return Ok(galerias);
        }

        [HttpGet]
        [Route("{galeriaId}/Imagens")]
        public async Task<IActionResult> ObterImagemsGaleria([FromRoute] int galeriaId)
        {
            var galerias = await _galeriaService.ObterImagens(galeriaId);
            return Ok(galerias);
        }
    }
}
