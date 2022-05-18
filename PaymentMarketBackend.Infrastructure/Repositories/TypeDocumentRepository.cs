using PaymentMarketBackend.Core.Entities;
using PaymentMarketBackend.Core.Interfaces.Repositories;
using PaymentMarketBackend.Infrastructure.Data;

namespace PaymentMarketBackend.Infrastructure.Repositories
{
    public class TypeDocumentRepository : BaseRepository<TypeDocument>, ITypeDocumentRepository
    {
        public TypeDocumentRepository(dbpaymentmarketContext context) : base(context)
        {
        }
    }
}