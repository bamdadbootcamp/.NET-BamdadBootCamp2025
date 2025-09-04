using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopApp.Domain.Entities;

namespace ShopApp.DAL.Configurations;

public class InvoiceDetailConfiguration : IEntityTypeConfiguration<InvoiceDetail>
{
    public void Configure(EntityTypeBuilder<InvoiceDetail> builder)
    {

        builder.Property(p => p.Quantity)
            .IsRequired();
        
        builder.Property(p => p.Price)
            .IsRequired();

        builder.HasOne(o => o.Product)
            .WithMany(m => m.InvoiceDetails)
            .HasForeignKey(f => f.ProductId)
            .IsRequired();
    }
}