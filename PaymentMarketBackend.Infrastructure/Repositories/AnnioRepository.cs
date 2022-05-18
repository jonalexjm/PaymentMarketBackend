using PaymentMarketBackend.Core.Entities;
using PaymentMarketBackend.Core.Interfaces;
using PaymentMarketBackend.Infrastructure.Data;

namespace PaymentMarketBackend.Infrastructure.Repositories
{
    public class AnnioRepository :  BaseRepository<Annio>, IAnnioRepository
    {
        public AnnioRepository(dbpaymentmarketContext context) : base(context)
        {
        }
    }
}