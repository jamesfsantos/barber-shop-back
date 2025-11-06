namespace BarberShop.Core.Models
{
    public class Galeria
    {
        public uint Id { get; set; }
        public string Nome { get; set; }
        public ICollection<GaleriaImagem> GaleriaImagems { get; set; }
    }
}
