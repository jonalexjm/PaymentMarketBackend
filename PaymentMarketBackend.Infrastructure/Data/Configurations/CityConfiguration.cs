using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaymentMarketBackend.Core.Entities;

namespace PaymentMarketBackend.Infrastructure.Data.Configurations
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("city");
            
            builder.HasKey(e => e.IdCity)
                .HasName("city_pkey");
            
            builder.Property(e => e.IdCity).HasColumnName("id_city");

            builder.Property(e => e.City1)
                .HasMaxLength(50)
                .HasColumnName("city");

            builder.Property(e => e.IdState).HasColumnName("id_state");

            builder.HasOne(d => d.IdStateNavigation)
                .WithMany(p => p.Cities)
                .HasForeignKey(d => d.IdState)
                .HasConstraintName("city_id_state_fkey");
        }
    }
}