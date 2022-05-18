using PaymentMarketBackend.Core.Entities;
using PaymentMarketBackend.Core.Interfaces.Repositories;
using PaymentMarketBackend.Infrastructure.Data;

namespace PaymentMarketBackend.Infrastructure.Repositories
{
    public class CountryRepository : BaseRepository<Country>, ICountryRepository
    {
        public CountryRepository(dbpaymentmarketContext context) : base(context)
        {
        }
    }
}