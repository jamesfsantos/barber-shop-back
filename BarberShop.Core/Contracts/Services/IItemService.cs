using BarberShop.Core.Models;

namespace BarberShop.Core.Contracts.Services
{
    public interface IItemService
    {
        Task<List<Item>> ObterTodosAsync();
    }
}
