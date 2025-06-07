using BookStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.DAL.Configurations;

public class BookCategoryConfiguration : IEntityTypeConfiguration<BookCategory>
{
    public void Configure(EntityTypeBuilder<BookCategory> builder)
    {
        builder.ToTable("Category","bs");

        builder.HasKey(k => k.Id);

        builder.Property(k => k.Title)
             .IsRequired()
             .HasMaxLength(128);

        builder.HasMany(k => k.Books)
            .WithOne(o => o.Category)
            .HasForeignKey(o => o.CategoryId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
