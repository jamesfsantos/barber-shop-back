using BarberShop.Core.Models;

namespace BarberShop.Core.Contracts.Services
{
    public interface IGaleriaService
    {
        Task<IEnumerable<Galeria>> ObterTodosAsync();
        Task<GaleriaDto> ObterImagens(int galeriaId);
    }
}
