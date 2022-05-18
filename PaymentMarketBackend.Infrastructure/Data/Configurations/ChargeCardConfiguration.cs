using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaymentMarketBackend.Core.Entities;

namespace PaymentMarketBackend.Infrastructure.Data.Configurations
{
    public class ChargeCardConfiguration : IEntityTypeConfiguration<ChargeCard>
    {
        public void Configure(EntityTypeBuilder<ChargeCard> builder)
        {
            builder.ToTable("charge_card");
            
            builder.HasKey(e => e.IdChargeCard)
                .HasName("charge_card_pkey");

            builder.Property(e => e.IdChargeCard).HasColumnName("id_charge_card");

            builder.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");

            builder.Property(e => e.IdAnnio).HasColumnName("id_annio");

            builder.Property(e => e.IdCustomer).HasColumnName("id_customer");

            builder.Property(e => e.IdMarket).HasColumnName("id_market");

            builder.Property(e => e.Valor).HasColumnName("valor");

            builder.HasOne(d => d.IdAnnioNavigation)
                .WithMany(p => p.ChargeCards)
                .HasForeignKey(d => d.IdAnnio)
                .HasConstraintName("charge_card_id_annio_fkey");

            builder.HasOne(d => d.IdCustomerNavigation)
                .WithMany(p => p.ChargeCards)
                .HasForeignKey(d => d.IdCustomer)
                .HasConstraintName("charge_card_id_customer_fkey");

            builder.HasOne(d => d.IdMarketNavigation)
                .WithMany(p => p.ChargeCards)
                .HasForeignKey(d => d.IdMarket)
                .HasConstraintName("charge_card_id_market_fkey");
        }
    }
}