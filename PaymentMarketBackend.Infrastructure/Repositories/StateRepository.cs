using PaymentMarketBackend.Core.Entities;
using PaymentMarketBackend.Core.Interfaces.Repositories;
using PaymentMarketBackend.Infrastructure.Data;

namespace PaymentMarketBackend.Infrastructure.Repositories
{
    public class StateRepository : BaseRepository<State>, IStateRepository
    {
        public StateRepository(dbpaymentmarketContext context) : base(context)
        {
        }
    }
}