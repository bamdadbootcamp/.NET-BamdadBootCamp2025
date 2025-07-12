using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserManagement.Domain.Entities;

namespace UserManagement.DAL.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable(nameof(User)); // => "User"

        builder.Property(p => p.Username)
            .IsRequired()
            .HasMaxLength(64);

        builder.HasIndex(p => p.Username)
            .IsUnique(true);

        builder.Property(p => p.Password)
            .IsRequired()
            .HasMaxLength(128);

        builder.Property(p => p.IsPasswordChangeRequire)
           .IsRequired();

        builder.Property(p => p.Email)
            .IsRequired()
            .HasMaxLength(128);

        builder.Property(p => p.Phonenumber)
            .IsRequired()
            .HasMaxLength(11);

        builder.Property(p => p.Address)
            .IsRequired(false)
            .HasMaxLength(256);

        builder.Property(p => p.Status)
            .IsRequired();

        builder.Property(p => p.LastLoginDateTime)
           .IsRequired(false);

    }
}
