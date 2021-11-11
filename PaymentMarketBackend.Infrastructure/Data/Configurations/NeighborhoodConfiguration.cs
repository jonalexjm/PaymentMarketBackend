using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaymentMarketBackend.Core.Entities;

namespace PaymentMarketBackend.Infrastructure.Data.Configurations
{
    public class NeighborhoodConfiguration : IEntityTypeConfiguration<Neighborhood>
    {
        public void Configure(EntityTypeBuilder<Neighborhood> builder)
        {
            builder.ToTable("neighborhood");
            
            builder.HasKey(e => e.IdNeighborhood)
                .HasName("neighborhood_pkey");

            builder.Property(e => e.IdNeighborhood).HasColumnName("id_neighborhood");

            builder.Property(e => e.IdCity).HasColumnName("id_city");

            builder.Property(e => e.Neighborhood1)
                .HasMaxLength(50)
                .HasColumnName("neighborhood");

            builder.HasOne(d => d.IdCityNavigation)
                .WithMany(p => p.Neighborhoods)
                .HasForeignKey(d => d.IdCity)
                .HasConstraintName("neighborhood_id_city_fkey");
        }
    }
}