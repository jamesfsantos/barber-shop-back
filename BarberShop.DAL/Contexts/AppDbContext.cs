using BarberShop.Core.Models;
using BarberShop.DAL.Contexts.Configurations;
using Microsoft.EntityFrameworkCore;

namespace BarberShop.DAL.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Catalogo> Catalogos { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ItemConfiguration());
            modelBuilder.ApplyConfiguration(new CatalogoConfiguration());
            modelBuilder.ApplyConfiguration(new CatalogoItemConfiguration());
        }
    }
}
