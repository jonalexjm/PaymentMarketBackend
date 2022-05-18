using System.Threading.Tasks;
using PaymentMarketBackend.Core.Interfaces;
using PaymentMarketBackend.Infrastructure.Data;

namespace PaymentMarketBackend.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly dbpaymentmarketContext _dbpaymentmarketContext;
        public UnitOfWork(dbpaymentmarketContext dbpaymentmarketContext)
        {
            _dbpaymentmarketContext = dbpaymentmarketContext;

        }
        
        #region Repositorios Seguridad
        public IAnnioRepository AnnioRepository => new AnnioRepository(_dbpaymentmarketContext);
        
        #endregion
        public void Dispose()
        {
            if (_dbpaymentmarketContext != null)
                _dbpaymentmarketContext.Dispose();
        }
        
        
        
        public void SaveChanges()
        {
            this._dbpaymentmarketContext.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await this._dbpaymentmarketContext.SaveChangesAsync();
        }
    }
}