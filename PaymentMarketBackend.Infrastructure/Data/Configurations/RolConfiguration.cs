using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaymentMarketBackend.Core.Entities;

namespace PaymentMarketBackend.Infrastructure.Data.Configurations
{
    public class RolConfiguration : IEntityTypeConfiguration<Rol>
    {
        public void Configure(EntityTypeBuilder<Rol> builder)
        {
            builder.ToTable("rol");
            
            builder.HasKey(e => e.IdRol)
                .HasName("rol_pkey");
            
            builder.Property(e => e.IdRol).HasColumnName("id_rol");

            builder.Property(e => e.RolName)
                .HasMaxLength(50)
                .HasColumnName("rol_name");
        }
    }
}