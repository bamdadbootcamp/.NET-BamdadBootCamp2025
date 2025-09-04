

using BookStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.DAL.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");
        builder.HasKey(u => u.Id);
        builder.Property(u => u.UserName)
            .IsRequired()
            .IsUnicode()
            .HasMaxLength(50);
        builder.Property(u => u.Password)
            .IsRequired()
            .HasMaxLength(100);
        builder.HasIndex(u => u.UserName);
    }
}
