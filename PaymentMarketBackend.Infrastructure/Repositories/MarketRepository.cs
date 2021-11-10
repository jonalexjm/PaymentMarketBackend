using PaymentMarketBackend.Core.Entities;
using PaymentMarketBackend.Core.Interfaces.Repositories;
using PaymentMarketBackend.Infrastructure.Data;

namespace PaymentMarketBackend.Infrastructure.Repositories
{
    public class MarketRepository : BaseRepository<Market>, IMarketRepository
    {
        public MarketRepository(dbpaymentmarketContext context) : base(context)
        {
        }
    }
}