using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaymentMarketBackend.Core.Entities;

namespace PaymentMarketBackend.Infrastructure.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("country");
            
            builder.HasKey(e => e.IdCountry)
                .HasName("country_pkey");

            builder.Property(e => e.IdCountry).HasColumnName("id_country");

            builder.Property(e => e.Country1)
                .HasMaxLength(50)
                .HasColumnName("country");
        }
    }
}