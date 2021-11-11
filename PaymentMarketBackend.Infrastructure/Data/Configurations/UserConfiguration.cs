using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaymentMarketBackend.Core.Entities;

namespace PaymentMarketBackend.Infrastructure.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("users");
            
            builder.HasKey(e => e.IdUser)
                .HasName("users_pkey");

            builder.Property(e => e.IdUser).HasColumnName("id_user");

            builder.Property(e => e.Address)
                .HasMaxLength(60)
                .HasColumnName("address");

            builder.Property(e => e.IdCity).HasColumnName("id_city");

            builder.Property(e => e.IdTypeDocument).HasColumnName("id_type_document");

            builder.Property(e => e.Lastname)
                .HasMaxLength(50)
                .HasColumnName("lastname");

            builder.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");

            builder.Property(e => e.NumberDocument)
                .HasMaxLength(50)
                .HasColumnName("number_document");

            builder.Property(e => e.Phone)
                .HasMaxLength(25)
                .HasColumnName("phone");

            builder.HasOne(d => d.IdCityNavigation)
                .WithMany(p => p.Users)
                .HasForeignKey(d => d.IdCity)
                .HasConstraintName("users_id_city_fkey");

            builder.HasOne(d => d.IdTypeDocumentNavigation)
                .WithMany(p => p.Users)
                .HasForeignKey(d => d.IdTypeDocument)
                .HasConstraintName("users_id_type_document_fkey");
        }
    }
}