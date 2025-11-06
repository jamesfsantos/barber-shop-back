using BarberShop.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarberShop.DAL.Contexts.Configurations
{
    public class GaleriaImagemConfiguration : IEntityTypeConfiguration<GaleriaImagem>
    {

        public void Configure(EntityTypeBuilder<GaleriaImagem> builder)
        {
            builder.ToTable("GaleriaImagem");
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Galeria)
                    .WithMany(x => x.GaleriaImagems)
                    .HasForeignKey(x => x.Galeria.Id);
            
            builder.Property(x => x.Caminho).HasColumnType("varchar").HasMaxLength(2048);
            builder.Property(x => x.Ativo).HasColumnType("bit");
            builder.Property(x => x.Ordem).HasColumnType("int");
            builder.Property(x => x.IsUrl).HasColumnType("bit");
        }
    }
}
