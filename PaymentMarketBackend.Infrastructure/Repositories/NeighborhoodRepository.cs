using PaymentMarketBackend.Core.Entities;
using PaymentMarketBackend.Core.Interfaces.Repositories;
using PaymentMarketBackend.Infrastructure.Data;

namespace PaymentMarketBackend.Infrastructure.Repositories
{
    public class NeighborhoodRepository : BaseRepository<Neighborhood>, INeighborhoodRepository
    {
        public NeighborhoodRepository(dbpaymentmarketContext context) : base(context)
        {
        }
    }
}