using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaymentMarketBackend.Core.Entities;

namespace PaymentMarketBackend.Infrastructure.Data.Configurations
{
    public class TypeDocumentConfiguration : IEntityTypeConfiguration<TypeDocument>
    {
        public void Configure(EntityTypeBuilder<TypeDocument> builder)
        {
            builder.ToTable("type_document");
            
            builder.HasKey(e => e.IdTypeDocument)
                .HasName("type_document_pkey");

            builder.Property(e => e.IdTypeDocument).HasColumnName("id_type_document");

            builder.Property(e => e.TypeDocument1)
                .HasMaxLength(50)
                .HasColumnName("type_document");
        }
    }
}