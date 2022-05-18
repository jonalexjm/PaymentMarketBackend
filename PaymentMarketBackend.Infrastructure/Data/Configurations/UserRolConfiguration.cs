using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaymentMarketBackend.Core.Entities;

namespace PaymentMarketBackend.Infrastructure.Data.Configurations
{
    public class UserRolConfiguration : IEntityTypeConfiguration<UserRol>
    {
        public void Configure(EntityTypeBuilder<UserRol> builder)
        {
            builder.ToTable("user_rol");
            
            builder.HasKey(e => e.IdUserRol)
                .HasName("user_rol_pkey");
            
            builder.Property(e => e.IdUserRol).HasColumnName("id_user_rol");

            builder.Property(e => e.IdRol).HasColumnName("id_rol");

            builder.Property(e => e.IdUser).HasColumnName("id_user");

            builder.HasOne(d => d.IdRolNavigation)
                .WithMany(p => p.UserRols)
                .HasForeignKey(d => d.IdRol)
                .HasConstraintName("user_rol_id_rol_fkey");

            builder.HasOne(d => d.IdUserNavigation)
                .WithMany(p => p.UserRols)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("user_rol_id_user_fkey");
        }
    }
}