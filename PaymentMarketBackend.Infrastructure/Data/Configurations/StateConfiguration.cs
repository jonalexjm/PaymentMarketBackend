using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaymentMarketBackend.Core.Entities;

namespace PaymentMarketBackend.Infrastructure.Data.Configurations
{
    public class StateConfiguration : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            builder.ToTable("state");
            
            builder.HasKey(e => e.IdState)
                .HasName("state_pkey");

            builder.Property(e => e.IdState).HasColumnName("id_state");

            builder.Property(e => e.IdCountry).HasColumnName("id_country");

            builder.Property(e => e.State1)
                .HasMaxLength(50)
                .HasColumnName("state");

            builder.HasOne(d => d.IdCountryNavigation)
                .WithMany(p => p.States)
                .HasForeignKey(d => d.IdCountry)
                .HasConstraintName("state_id_country_fkey");
        }
    }
}