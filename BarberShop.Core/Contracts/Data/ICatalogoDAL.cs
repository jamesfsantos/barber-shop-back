using BarberShop.Core.Models;

namespace BarberShop.Core.Contracts.Data
{
    public interface ICatalogoDAL
    {
        Task<Catalogo> ObterItens(int catlogoId);
        Task<IEnumerable<Catalogo>> ObterTodosAsync();
    }
}
