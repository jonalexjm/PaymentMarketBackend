using PaymentMarketBackend.Core.Entities;
using PaymentMarketBackend.Core.Interfaces.Repositories;
using PaymentMarketBackend.Infrastructure.Data;

namespace PaymentMarketBackend.Infrastructure.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(dbpaymentmarketContext context) : base(context)
        {
        }
    }
}