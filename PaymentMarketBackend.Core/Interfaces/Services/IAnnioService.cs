using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentMarketBackend.Core.Entities;

namespace PaymentMarketBackend.Core.Interfaces.Services
{
    public interface IAnnioService
    {
        Task<List<Annio>> GetAllAnnio();
        Task CreateAnnio(Annio annio);

    }
}