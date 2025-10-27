using BarberShop.Core.Contracts.Data;
using BarberShop.Core.Contracts.Services;
using BarberShop.Core.Dtos;
using BarberShop.Core.Models;

namespace BarberShop.BLL
{
    public class CatalogoService : ICatalogoService
    {

        private readonly ICatalogoDAL _catalogoDAL;
        public CatalogoService(ICatalogoDAL catalogoDAL)
        {
            _catalogoDAL = catalogoDAL;
        }

        public async Task<IEnumerable<Catalogo>> ObterTodosAsync()
        {
            return await _catalogoDAL.ObterTodosAsync();
        }


        public async Task<CatalogoDto> ObterItens(int catalogoId)
        {
            var catalogo = await _catalogoDAL.ObterItens(catalogoId);
            return new CatalogoDto(catalogo);

        }


    }
}
