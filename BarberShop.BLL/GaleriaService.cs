using BarberShop.Core.Contracts.Data;
using BarberShop.Core.Contracts.Services;
using BarberShop.Core.Models;

namespace BarberShop.BLL
{
    public class GaleriaService : IGaleriaService
    {

        private readonly IGaleriaDAL _galeriaDAL;


        public GaleriaService(IGaleriaDAL galeriaDAL)
        {
            _galeriaDAL = galeriaDAL;
        }

        public async Task<IEnumerable<Galeria>> ObterTodosAsync()
        {
            return await _galeriaDAL.ObterTodosAsync();
        }

        public async Task<GaleriaDto> ObterImagens(int galeriaId)
        {
            var galeria = await _galeriaDAL.ObterImagems(galeriaId);
            return new GaleriaDto(galeria);

        }


    }
}
