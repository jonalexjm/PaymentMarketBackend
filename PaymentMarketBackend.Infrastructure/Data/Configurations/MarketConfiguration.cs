using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaymentMarketBackend.Core.Entities;

namespace PaymentMarketBackend.Infrastructure.Data.Configurations
{
    public class MarketConfiguration : IEntityTypeConfiguration<Market>
    {
        public void Configure(EntityTypeBuilder<Market> builder)
        {
            builder.ToTable("market");
            
            builder.HasKey(e => e.IdMarket)
                .HasName("market_pkey");

            builder.Property(e => e.IdMarket).HasColumnName("id_market");

            builder.Property(e => e.IdNeighborhood).HasColumnName("id_neighborhood");

            builder.Property(e => e.Market1)
                .HasMaxLength(50)
                .HasColumnName("market");

            builder.HasOne(d => d.IdNeighborhoodNavigation)
                .WithMany(p => p.Markets)
                .HasForeignKey(d => d.IdNeighborhood)
                .HasConstraintName("market_id_neighborhood_fkey");
        }
    }
}