using BarberShop.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarberShop.DAL.Contexts.Configurations
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Item");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasColumnName("Nome").HasColumnType("varchar(255)").HasMaxLength(255).IsRequired();
            builder.Property(x => x.Preco).HasColumnName("Preco").HasColumnType("decimal(10,2)").IsRequired();
        }
    }
}
