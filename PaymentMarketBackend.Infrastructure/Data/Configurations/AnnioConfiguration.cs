using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaymentMarketBackend.Core.Entities;

namespace PaymentMarketBackend.Infrastructure.Data.Configurations
{
    public class AnnioConfiguration : IEntityTypeConfiguration<Annio>
    {
        public void Configure(EntityTypeBuilder<Annio> builder)
        {
            builder.ToTable("annio");
            builder.HasKey(e => e.IdAnnio)
            .HasName("annio_pkey");

            builder.Property(e => e.IdAnnio).HasColumnName("id_annio");

            builder.Property(e => e.Annio1).HasColumnName("annio");
        }
    }
}