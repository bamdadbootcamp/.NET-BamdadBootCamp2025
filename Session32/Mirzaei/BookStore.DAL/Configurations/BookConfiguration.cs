using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookStore.Domain.Entities;


namespace BookStore.DAL.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>

    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Books");

            builder.HasKey(b => b.Id);

            builder.Property(b => b.Title)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(b => b.Author)
                  .IsRequired()
                  .HasMaxLength(100);

            builder.Property(b => b.Publisher)
                   .HasMaxLength(100);

            builder.Property(b => b.Edition)
                .HasMaxLength (50);

            builder.Property(b => b.Isbn)
                   .IsRequired()
                   .IsUnicode()
                   .HasMaxLength(17);

            builder.HasOne(b => b.Language)
                .WithMany(l => l.Books)
                .HasForeignKey(b => b.LanguageId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(b => b.Category)
                .WithMany(c => c.Books)
                .HasForeignKey(b => b.CategoryId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Property(b => b.SalePrice)
                .IsRequired()
                  .HasPrecision(18, 2);

            builder.Property(b => b.RentPrice)
                .IsRequired()
                   .HasPrecision(18, 2);

            builder.Property(b => b.Dimensions)
                 .HasMaxLength(50);

            builder.Property(b => b.WeightGrams)
                   .HasPrecision(18, 2);            

            builder.Property(b => b.Description)
                   .HasColumnType("nvarchar(max)");

            builder.Property(b => b.CoverImagePath)
                .HasMaxLength(200);

            builder.HasIndex(b => b.CategoryId);

            builder.HasIndex(b => b.LanguageId);

            
        }
    }
}
