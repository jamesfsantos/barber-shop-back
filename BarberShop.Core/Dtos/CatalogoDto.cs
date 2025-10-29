using BarberShop.Core.Models;

namespace BarberShop.Core.Dtos
{
    public class CatalogoDto
    {
        public CatalogoDto(Catalogo catalogo)
        {
            Id = catalogo.Id;
            Nome = catalogo.Nome;

            if (catalogo.CatalogosItems!=null && catalogo.CatalogosItems.Any())
            {
                CatalogosItems = catalogo.CatalogosItems.Select(catalogoItem=>new CatalogoItemDto(catalogoItem)).OrderBy(x => x.Ordem).ToList();
            }


        }

        public CatalogoDto()
        {

        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public List<CatalogoItemDto> CatalogosItems { get; set; }
    }
}
