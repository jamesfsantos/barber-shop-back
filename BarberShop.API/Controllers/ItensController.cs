using BarberShop.Core.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace BarberShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItensController : ControllerBase
    {
        private readonly IItemService _itemService;
        public ItensController(IItemService itemService) 
        {
            _itemService = itemService;
        }
        
        [HttpGet]
        public async Task<IActionResult> ObterItens()
        {
            var itens = await _itemService.ObterTodosAsync();
            return Ok(itens);
        }
    }
}
