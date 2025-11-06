using BarberShop.Core.Models;

namespace BarberShop.Core.Dtos
{
    public class GaleriaImagemDto
    {
        public GaleriaImagemDto(GaleriaImagem galeriaImagem)
        {
            Id = galeriaImagem.Id;            
            Caminho = galeriaImagem.Caminho;
            Ativo = galeriaImagem.Ativo;
            Ordem = galeriaImagem.Ordem;
            IsUrl = galeriaImagem.IsUrl;
        }

        public uint Id { get; set; }

        public string Caminho { get; set; }
        public bool Ativo { get; set; }
        public int Ordem { get; set; }
        public bool IsUrl { get; set; }
    }
}
