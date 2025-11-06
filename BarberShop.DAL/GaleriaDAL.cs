using BarberShop.Core.Contracts.Data;
using BarberShop.Core.Models;
using BarberShop.DAL.Contexts;
using Microsoft.EntityFrameworkCore;

namespace BarberShop.DAL
{
    public class GaleriaDAL : IGaleriaDAL
    {
        private readonly AppDbContext _context;

        public GaleriaDAL(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Galeria> ObterImagems(int galeriaId)
        {
            var galeria = await _context.Galerias
                .Include(x => x.GaleriaImagems)
                .Where(x => x.Id == galeriaId).FirstOrDefaultAsync();
            return galeria;
        }

        public async Task<IEnumerable<Galeria>> ObterTodosAsync()
        {
            return await _context.Galerias.ToListAsync();
        }
    }
}
