using BarberShop.Core.Contracts.Data;
using BarberShop.Core.Contracts.Services;
using BarberShop.Core.Models;

namespace BarberShop.BLL
{
    public class ItemService : IItemService
    {
        private readonly IItemDAL _itemDAL;
        public ItemService(IItemDAL itemDAL) { 
            _itemDAL = itemDAL;
        }
        public async Task<List<Item>> ObterTodosAsync()
        {
            return await _itemDAL.ObterTodosAsync(); 
        }
    }
}
