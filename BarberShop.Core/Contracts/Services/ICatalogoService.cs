using BarberShop.Core.Dtos;
using BarberShop.Core.Models;

namespace BarberShop.Core.Contracts.Services
{
    public interface ICatalogoService
    {
        Task<CatalogoDto> ObterItens(int catalogoId);
        Task<IEnumerable<Catalogo>> ObterTodosAsync();
    }
}
