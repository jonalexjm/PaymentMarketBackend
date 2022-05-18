using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentMarketBackend.Core.CustomEntities;
using PaymentMarketBackend.Core.Entities;
using PaymentMarketBackend.Core.QueryFilters;

namespace PaymentMarketBackend.Core.Interfaces.Services
{
    public interface IAnnioService
    {
        Task<PagedList<Annio>> GetAllAnnio(AnnioQueryFilter filters);
        Task CreateAnnio(Annio annio);

    }
}