namespace BarberShop.Core.Models
{
    public class CatalogoItem
    {
        public int Id { get; set; }
        public int CatalogoId { get; set; }
        public int ItemId { get; set; }
        public int Ordem { get; set; } = 1;
        public Item Item { get; set; }
        public Catalogo Catalogo { get; set; }
    }
}
