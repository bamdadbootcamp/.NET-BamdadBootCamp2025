using BookStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.DAL.Configurations;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(k => k.Id);

        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(256);
            //.HasColumnType("varchar")
            //.HasColumnName("Title")
        
        builder.Property(p => p.Price)
            .IsRequired()
            .HasColumnType("decimal(18,0)");

        builder.Property(p => p.RentPricePerDay)
            .IsRequired(false)
            .HasColumnType("decimal(18,0)");

        builder.Property(p => p.FinePricePerDay)
            .IsRequired(false)
            .HasColumnType("decimal(18,0)");

        builder.Property(p => p.PageCount)
            .IsRequired();

        builder.Property(p => p.ISBN)
           .IsRequired()
           .HasMaxLength(13);

        builder.HasOne(p => p.Publisher)
            .WithMany(m => m.Books)
            .HasForeignKey(f => f.PublisherId)
            .OnDelete(DeleteBehavior.Restrict);

    }
}
