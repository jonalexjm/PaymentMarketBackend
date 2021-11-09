using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

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
        public virtual DbSet<TypeIdentification> TypeIdentifications { get; set; }
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
            modelBuilder.Entity<Annio>(entity =>
            {
                entity.HasKey(e => e.IdAnnio)
                    .HasName("annio_pkey");

                entity.ToTable("annio");

                entity.Property(e => e.IdAnnio).HasColumnName("id_annio");

                entity.Property(e => e.Annio1).HasColumnName("annio");
            });

            modelBuilder.Entity<ChargeCard>(entity =>
            {
                entity.HasKey(e => e.IdChargeCard)
                    .HasName("charge_card_pkey");

                entity.ToTable("charge_card");

                entity.Property(e => e.IdChargeCard).HasColumnName("id_charge_card");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("description");

                entity.Property(e => e.IdAnnio).HasColumnName("id_annio");

                entity.Property(e => e.IdCustomer).HasColumnName("id_customer");

                entity.Property(e => e.IdMarket).HasColumnName("id_market");

                entity.Property(e => e.Valor).HasColumnName("valor");

                entity.HasOne(d => d.IdAnnioNavigation)
                    .WithMany(p => p.ChargeCards)
                    .HasForeignKey(d => d.IdAnnio)
                    .HasConstraintName("charge_card_id_annio_fkey");

                entity.HasOne(d => d.IdCustomerNavigation)
                    .WithMany(p => p.ChargeCards)
                    .HasForeignKey(d => d.IdCustomer)
                    .HasConstraintName("charge_card_id_customer_fkey");

                entity.HasOne(d => d.IdMarketNavigation)
                    .WithMany(p => p.ChargeCards)
                    .HasForeignKey(d => d.IdMarket)
                    .HasConstraintName("charge_card_id_market_fkey");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasKey(e => e.IdCity)
                    .HasName("city_pkey");

                entity.ToTable("city");

                entity.Property(e => e.IdCity).HasColumnName("id_city");

                entity.Property(e => e.City1)
                    .HasMaxLength(50)
                    .HasColumnName("city");

                entity.Property(e => e.IdState).HasColumnName("id_state");

                entity.HasOne(d => d.IdStateNavigation)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.IdState)
                    .HasConstraintName("city_id_state_fkey");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.IdCountry)
                    .HasName("country_pkey");

                entity.ToTable("country");

                entity.Property(e => e.IdCountry).HasColumnName("id_country");

                entity.Property(e => e.Country1)
                    .HasMaxLength(50)
                    .HasColumnName("country");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasKey(e => e.IdInvoice)
                    .HasName("invoice_pkey");

                entity.ToTable("invoice");

                entity.Property(e => e.IdInvoice).HasColumnName("id_invoice");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.IdChargeCard).HasColumnName("id_charge_card");

                entity.Property(e => e.IdCobrador).HasColumnName("id_cobrador");

                entity.Property(e => e.Valor).HasColumnName("valor");

                entity.HasOne(d => d.IdChargeCardNavigation)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.IdChargeCard)
                    .HasConstraintName("invoice_id_charge_card_fkey");

                entity.HasOne(d => d.IdCobradorNavigation)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.IdCobrador)
                    .HasConstraintName("invoice_id_cobrador_fkey");
            });

            modelBuilder.Entity<Market>(entity =>
            {
                entity.HasKey(e => e.IdMarket)
                    .HasName("market_pkey");

                entity.ToTable("market");

                entity.Property(e => e.IdMarket).HasColumnName("id_market");

                entity.Property(e => e.IdNeighborhood).HasColumnName("id_neighborhood");

                entity.Property(e => e.Market1)
                    .HasMaxLength(50)
                    .HasColumnName("market");

                entity.HasOne(d => d.IdNeighborhoodNavigation)
                    .WithMany(p => p.Markets)
                    .HasForeignKey(d => d.IdNeighborhood)
                    .HasConstraintName("market_id_neighborhood_fkey");
            });

            modelBuilder.Entity<Neighborhood>(entity =>
            {
                entity.HasKey(e => e.IdNeighborhood)
                    .HasName("neighborhood_pkey");

                entity.ToTable("neighborhood");

                entity.Property(e => e.IdNeighborhood).HasColumnName("id_neighborhood");

                entity.Property(e => e.IdCity).HasColumnName("id_city");

                entity.Property(e => e.Neighborhood1)
                    .HasMaxLength(50)
                    .HasColumnName("neighborhood");

                entity.HasOne(d => d.IdCityNavigation)
                    .WithMany(p => p.Neighborhoods)
                    .HasForeignKey(d => d.IdCity)
                    .HasConstraintName("neighborhood_id_city_fkey");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("rol_pkey");

                entity.ToTable("rol");

                entity.Property(e => e.IdRol).HasColumnName("id_rol");

                entity.Property(e => e.RolName)
                    .HasMaxLength(50)
                    .HasColumnName("rol_name");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasKey(e => e.IdState)
                    .HasName("state_pkey");

                entity.ToTable("state");

                entity.Property(e => e.IdState).HasColumnName("id_state");

                entity.Property(e => e.IdCountry).HasColumnName("id_country");

                entity.Property(e => e.State1)
                    .HasMaxLength(50)
                    .HasColumnName("state");

                entity.HasOne(d => d.IdCountryNavigation)
                    .WithMany(p => p.States)
                    .HasForeignKey(d => d.IdCountry)
                    .HasConstraintName("state_id_country_fkey");
            });

            modelBuilder.Entity<TypeDocument>(entity =>
            {
                entity.HasKey(e => e.IdTypeDocument)
                    .HasName("type_document_pkey");

                entity.ToTable("type_document");

                entity.Property(e => e.IdTypeDocument).HasColumnName("id_type_document");

                entity.Property(e => e.TypeDocument1)
                    .HasMaxLength(50)
                    .HasColumnName("type_document");
            });

            modelBuilder.Entity<TypeIdentification>(entity =>
            {
                entity.HasKey(e => e.IdTypeIdentification)
                    .HasName("type_identification_pkey");

                entity.ToTable("type_identification");

                entity.Property(e => e.IdTypeIdentification).HasColumnName("id_type_identification");

                entity.Property(e => e.TypeIdentification1)
                    .HasMaxLength(50)
                    .HasColumnName("type_identification");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("users_pkey");

                entity.ToTable("users");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.Address)
                    .HasMaxLength(60)
                    .HasColumnName("address");

                entity.Property(e => e.IdCity).HasColumnName("id_city");

                entity.Property(e => e.IdTypeDocument).HasColumnName("id_type_document");

                entity.Property(e => e.IdTypeIdentification).HasColumnName("id_type_identification");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(50)
                    .HasColumnName("lastname");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.NumberDocument)
                    .HasMaxLength(50)
                    .HasColumnName("number_document");

                entity.Property(e => e.Phone)
                    .HasMaxLength(25)
                    .HasColumnName("phone");

                entity.HasOne(d => d.IdCityNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.IdCity)
                    .HasConstraintName("users_id_city_fkey");

                entity.HasOne(d => d.IdTypeDocumentNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.IdTypeDocument)
                    .HasConstraintName("users_id_type_document_fkey");

                entity.HasOne(d => d.IdTypeIdentificationNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.IdTypeIdentification)
                    .HasConstraintName("users_id_type_identification_fkey");
            });

            modelBuilder.Entity<UserRol>(entity =>
            {
                entity.HasKey(e => e.IdUserRol)
                    .HasName("user_rol_pkey");

                entity.ToTable("user_rol");

                entity.Property(e => e.IdUserRol).HasColumnName("id_user_rol");

                entity.Property(e => e.IdRol).HasColumnName("id_rol");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.UserRols)
                    .HasForeignKey(d => d.IdRol)
                    .HasConstraintName("user_rol_id_rol_fkey");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.UserRols)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("user_rol_id_user_fkey");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
