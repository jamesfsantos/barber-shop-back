namespace BarberShop.Core.Models
{
    public class GaleriaImagem
    {
        public uint Id { get; set; }
        public Galeria Galeria { get; set; }
        public string Caminho { get; set; }
        public bool Ativo { get; set; }
        public int Ordem { get; set; }
        public bool IsUrl { get; set; }

        public uint GaleriaId { get; set; }

    }
}
