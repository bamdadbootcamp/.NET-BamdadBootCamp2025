using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopApp.Domain.Entities;

namespace ShopApp.DAL.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(p => p.Title)
            .HasMaxLength(128)
            .IsRequired();
        
        builder.Property(p => p.Price)
            .IsRequired();

        builder.HasOne(o => o.ProductCategory)
            .WithMany(m => m.Products)
            .HasForeignKey(f => f.ProductCategoryId)
            .IsRequired();
    }
}