using CRM.WebApi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.WebApi.Configuration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");

        builder.Property(p => p.Username)
            .IsRequired()
            .HasMaxLength(64);
        
        builder.Property(p => p.Password)
            .IsRequired()
            .HasMaxLength(512);

        builder.HasIndex(p => p.Username)
            .IsUnique();

        builder.Property(p => p.UserType)
            .IsRequired();
    }
}