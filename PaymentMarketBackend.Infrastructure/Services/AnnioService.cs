using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentMarketBackend.Core.Entities;
using PaymentMarketBackend.Core.Interfaces;
using PaymentMarketBackend.Core.Interfaces.Services;
using PaymentMarketBackend.Core.QueryFilters;

namespace PaymentMarketBackend.Infrastructure.Services
{
    public class AnnioService : IAnnioService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AnnioService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Annio>> GetAllAnnio(AnnioQueryFilter filters)
        {
            var annios = this._unitOfWork.AnnioRepository.GetAll().ToList();

            if (filters.Annio != null)
            {
                annios = annios.Where(x => x.Annio1 == filters.Annio).ToList();
            }
            
            return annios;

        }

        public async Task CreateAnnio(Annio annio)
        {
            await  _unitOfWork.AnnioRepository.Add(annio);
            await _unitOfWork.SaveChangesAsync();
        }
        
    }
}