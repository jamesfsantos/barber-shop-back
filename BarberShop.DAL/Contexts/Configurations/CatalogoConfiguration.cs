using BarberShop.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarberShop.DAL.Contexts.Configurations
{
    public class CatalogoConfiguration : IEntityTypeConfiguration<Catalogo>
    {
        public void Configure(EntityTypeBuilder<Catalogo> builder)
        {
            builder.ToTable("Catalogo");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasColumnType("varchar(45)").HasMaxLength(45);
        }
    }
}
