using BarberShop.Core.Contracts.Data;
using BarberShop.Core.Models;
using BarberShop.DAL.Contexts;
using Microsoft.EntityFrameworkCore;

namespace BarberShop.DAL
{
    public class ItemDAL : IItemDAL
    {
        private readonly AppDbContext _context;

        public ItemDAL(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Item>> ObterTodosAsync()
        {
            var items = await _context.Items.ToListAsync();
            return items;
        }
    }
}
