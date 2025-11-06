namespace BarberShop.Core.Models
{
    public class Catalogo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<CatalogoItem> CatalogosItems { get; set; }
    }
}
