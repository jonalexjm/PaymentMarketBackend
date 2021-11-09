using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentMarketBackend.Core.Entities;
using PaymentMarketBackend.Core.Interfaces;
using PaymentMarketBackend.Core.Interfaces.Services;

namespace PaymentMarketBackend.Infrastructure.Services
{
    public class AnnioService : IAnnioService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AnnioService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Annio>> GetAllAnnio()
        {
            return this._unitOfWork.AnnioRepository.GetAll().ToList();
            
        }
    }
}