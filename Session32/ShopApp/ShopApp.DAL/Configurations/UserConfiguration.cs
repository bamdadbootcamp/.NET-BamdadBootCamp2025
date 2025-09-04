using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopApp.Domain.Entities;

namespace ShopApp.DAL.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Property(p => p.Username)
            .HasMaxLength(128)
            .IsRequired();
        
        builder.Property(p => p.Password)
            .HasMaxLength(512)
            .IsRequired();

        builder.Property(p => p.IsLocked)
            .IsRequired();
        
        builder.Property(p => p.LastLoginDateTime)
            .IsRequired(false);
        
        builder.HasMany(m => m.Invoices)
            .WithOne(m => m.User)
            .HasForeignKey(f => f.UserId)
            .IsRequired(false);
    }
}