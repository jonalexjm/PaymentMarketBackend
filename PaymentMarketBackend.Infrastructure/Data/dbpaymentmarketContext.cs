using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PaymentMarketBackend.Core.Entities;
using PaymentMarketBackend.Infrastructure.Data.Configurations;


#nullable disable

namespace PaymentMarketBackend.Infrastructure.Data
{
    public partial class dbpaymentmarketContext : DbContext
    {
        public dbpaymentmarketContext()
        {
        }

        public dbpaymentmarketContext(DbContextOptions<dbpaymentmarketContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Annio> Annios { get; set; }
        public virtual DbSet<ChargeCard> ChargeCards { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Market> Markets { get; set; }
        public virtual DbSet<Neighborhood> Neighborhoods { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<TypeDocument> TypeDocuments { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRol> UserRols { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost; port=5432;Database=dbpaymentmarket;Username=postgres;Password=jonalexjm");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AnnioConfiguration());
            modelBuilder.ApplyConfiguration(new ChargeCardConfiguration());
            modelBuilder.ApplyConfiguration(new CityConfiguration());
            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new InvoiceConfiguration());
            modelBuilder.ApplyConfiguration(new MarketConfiguration());
            modelBuilder.ApplyConfiguration(new NeighborhoodConfiguration());
            modelBuilder.ApplyConfiguration(new RolConfiguration());
            modelBuilder.ApplyConfiguration(new StateConfiguration());
            modelBuilder.ApplyConfiguration(new TypeDocumentConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserRolConfiguration());
            

        }
    }
}
