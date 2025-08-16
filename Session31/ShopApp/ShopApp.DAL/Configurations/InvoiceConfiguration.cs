using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopApp.Domain.Entities;

namespace ShopApp.DAL.Configurations;

public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
{
    public void Configure(EntityTypeBuilder<Invoice> builder)
    {
        builder.Property(p => p.Number)
            .HasMaxLength(32)
            .IsRequired();
        
        builder.Property(p => p.InvoiceDateTime)
            .IsRequired();
        
        builder.Property(p => p.TotalPrice)
            .IsRequired();
        
        builder.Property(p => p.DiscountPercentage)
            .IsRequired();

        builder.HasMany(m => m.InvoiceDetails)
            .WithOne(o => o.Invoice)
            .HasForeignKey(f => f.InvoiceId)
            .IsRequired();
    }
}