using BankManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankManagement.DAL.Configurations;

public class BankAccountConfiguration : IEntityTypeConfiguration<BankAccount>
{
    public void Configure(EntityTypeBuilder<BankAccount> builder)
    {
        builder.Property(f => f.AccountNumber).IsRequired().HasMaxLength(26);

        builder.Property(f => f.CustomerId).IsRequired();

        builder.HasIndex(i => new { i.AccountNumber, i.CustomerId }).IsUnique(true);
    }
}
