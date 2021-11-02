

using System.Reflection;
using Microsoft.EntityFrameworkCore;
using PaymentMarketBackend.Core;

namespace PaymentMarketBackend.Infrastructure.Data
{
    public class PaymentContext : DbContext 
    {
        public PaymentContext()
        {
                
        }
        
        public PaymentContext(DbContextOptions<PaymentContext> options) : base(options)
        {
            
        }
        
        public virtual DbSet<TypeDocument> TypeDocuments { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}