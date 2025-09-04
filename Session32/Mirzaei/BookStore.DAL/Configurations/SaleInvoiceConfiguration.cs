using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DAL.Configurations
{
    public class SaleInvoiceConfiguration : IEntityTypeConfiguration<SaleInvoice>
    {
        public void Configure(EntityTypeBuilder<SaleInvoice> builder)
        {
            builder.ToTable("SaleInvoices");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.SaleInvoiceNumber)
                   .IsRequired()
                   .IsUnicode()
                   .HasMaxLength(40);

            builder.HasOne(s => s.Customer)
                   .WithMany(c => c.SaleInvoices)
                   .HasForeignKey(s => s.CustomerId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.Property(s => s.TotalAmount)
                  .HasPrecision(18, 2);

            builder.Property(s => s.DiscountAmount)
                   .HasPrecision(18, 2);

            builder.HasOne(s => s.PaymentMethod)
                   .WithMany(p => p.SaleInvoices)
                   .HasForeignKey(s => s.PaymentMethodId)
                   .OnDelete(DeleteBehavior.NoAction) ;

            builder.Property(s => s.SellerName)
                     .IsRequired()
                     .HasMaxLength(100);

            builder.Property(s => s.Description)
                        .HasMaxLength(500);
        }
    }
}
