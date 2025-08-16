using BankManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankManagement.DAL.Configurations;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.Property(f => f.FirstName).IsRequired().HasMaxLength(100);

        builder.Property(f => f.LastName).IsRequired().HasMaxLength(100);

        builder.Property(f => f.NationalId).IsRequired().HasMaxLength(10);

        builder.HasMany(f => f.BankAccounts).WithOne(m => m.Customer)
            .HasForeignKey(m => m.CustomerId);

        builder.HasIndex(i => i.NationalId).IsUnique(true);
    }
}
