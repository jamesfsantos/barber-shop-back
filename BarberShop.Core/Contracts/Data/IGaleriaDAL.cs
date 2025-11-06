using BarberShop.Core.Models;

namespace BarberShop.Core.Contracts.Data
{
    public interface IGaleriaDAL
    {
        Task<Galeria> ObterImagems(int galeriaId);
        Task<IEnumerable<Galeria>> ObterTodosAsync();
    }
}
