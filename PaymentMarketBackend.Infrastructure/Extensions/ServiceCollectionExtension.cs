using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PaymentMarketBackend.Core.Interfaces;
using PaymentMarketBackend.Core.Interfaces.Services;
using PaymentMarketBackend.Infrastructure.Data;
using PaymentMarketBackend.Infrastructure.Repositories;
using PaymentMarketBackend.Infrastructure.Services;

namespace PaymentMarketBackend.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddDbContexts(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<dbpaymentmarketContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("dbPaymentMarket"))
            );

            return services;
        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<IAnnioService, AnnioService>();
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }


    }
}