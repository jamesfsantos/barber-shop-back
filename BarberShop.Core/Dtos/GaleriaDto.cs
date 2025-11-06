using BarberShop.Core.Dtos;
using BarberShop.Core.Models;

public class GaleriaDto
{
    public GaleriaDto(Galeria galeria)
    {
        Id = galeria.Id;
        Nome = galeria.Nome;

        if (galeria.GaleriaImagems != null && galeria.GaleriaImagems.Any())
        {
            Imagens = galeria.GaleriaImagems.Select(galeriaImagem => new GaleriaImagemDto(galeriaImagem)).OrderBy(x => x.Ordem).ToList();
        }


    }

    public GaleriaDto()
    {

    }

    public uint Id { get; set; }
    public string Nome { get; set; }
    public IEnumerable<GaleriaImagemDto> Imagens { get; set; }
}