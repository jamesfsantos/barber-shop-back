using BarberShop.Core.Contracts.Data;
using BarberShop.Core.Models;
using BarberShop.DAL.Contexts;
using Microsoft.EntityFrameworkCore;

namespace BarberShop.DAL
{
    public class CatalogoDAL : ICatalogoDAL
    {
        private readonly AppDbContext _context;

        public CatalogoDAL(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Catalogo> ObterItens(int catalogoId)
        {
            var catalogo = await _context.Catalogos
                .Include(x => x.CatalogosItems)
                    .ThenInclude(catalogoItem => catalogoItem.Item)
                .Where(x => x.Id == catalogoId).FirstOrDefaultAsync();
            return catalogo;

        }

        public async Task<IEnumerable<Catalogo>> ObterTodosAsync()
        {
            return await _context.Catalogos.ToListAsync();
        }
    }
}
