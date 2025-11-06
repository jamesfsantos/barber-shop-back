using BarberShop.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarberShop.DAL.Contexts.Configurations
{
    public class CatalogoItemConfiguration : IEntityTypeConfiguration<CatalogoItem>
    {
        public void Configure(EntityTypeBuilder<CatalogoItem> builder)
        {
            builder.ToTable("CatalogoItem");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Ordem).HasColumnType("int");

            builder.HasOne(x => x.Catalogo)
                   .WithMany(x => x.CatalogosItems)
                   .HasForeignKey(x => x.CatalogoId);

            builder.HasOne(x => x.Item)
                   .WithMany()
                   .HasForeignKey(x => x.ItemId);
        }
    }
}
