using System;
using System.Threading.Tasks;

namespace PaymentMarketBackend.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAnnioRepository AnnioRepository { get; }
        
        void SaveChanges();

        Task SaveChangesAsync();
        
    }
}