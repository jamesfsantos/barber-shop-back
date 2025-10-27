using BarberShop.Core.Models;

namespace BarberShop.Core.Dtos
{
    public class CatalogoItemDto
    {
        public CatalogoItemDto(CatalogoItem catalogoItem)
        {
            Id = catalogoItem.Id;
            CatalogoId = catalogoItem.CatalogoId;
            ItemId = catalogoItem.ItemId;   
            Ordem = catalogoItem.Ordem;
            Item = catalogoItem.Item.Nome;
        }

        public CatalogoItemDto()
        {
            
        }

        public int Id { get; set; }
        public int CatalogoId { get; set; }
        public int ItemId { get; set; }
        public int Ordem { get; set; } = 1;
        public string Item { get; set; }
        
    }
}
