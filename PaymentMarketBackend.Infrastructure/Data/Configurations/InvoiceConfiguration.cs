using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaymentMarketBackend.Core.Entities;

namespace PaymentMarketBackend.Infrastructure.Data.Configurations
{
    public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.ToTable("invoice");
            
            builder.HasKey(e => e.IdInvoice)
                .HasName("invoice_pkey");

            builder.Property(e => e.IdInvoice).HasColumnName("id_invoice");

            builder.Property(e => e.Date).HasColumnName("date");

            builder.Property(e => e.IdChargeCard).HasColumnName("id_charge_card");

            builder.Property(e => e.IdCobrador).HasColumnName("id_cobrador");

            builder.Property(e => e.Valor).HasColumnName("valor");

            builder.HasOne(d => d.IdChargeCardNavigation)
                .WithMany(p => p.Invoices)
                .HasForeignKey(d => d.IdChargeCard)
                .HasConstraintName("invoice_id_charge_card_fkey");

            builder.HasOne(d => d.IdCobradorNavigation)
                .WithMany(p => p.Invoices)
                .HasForeignKey(d => d.IdCobrador)
                .HasConstraintName("invoice_id_cobrador_fkey");
            
        }
    }
}