using BarberShop.Core.Contracts.Data;
using BarberShop.DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BarberShop.DAL
{
    public static class BarberShopDalModule
    {
        public static IServiceCollection AddData(this IServiceCollection services, IConfiguration configuration)
        {
            // adicione as linhas abaixo dentro da função que já existe
            var connection = configuration.GetConnectionString("Default");
            //services.AddDbContext<AppDbContext>(options => options.UseMySql(connection, ServerVersion.AutoDetect(connection)));
            services.AddDbContext<AppDbContext>(options=>options.UseMySQL(connection!));

            services.AddScoped<IItemDAL, ItemDAL>();
            services.AddScoped<ICatalogoDAL, CatalogoDAL>();


            return services;
        }
    }
}
