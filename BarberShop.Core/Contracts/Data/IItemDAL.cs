using BarberShop.Core.Models;

namespace BarberShop.Core.Contracts.Data
{
    public interface IItemDAL
    {
        Task<List<Item>> ObterTodosAsync();
    }
}
