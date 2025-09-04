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
    public class RentInvoiceConfiguration : IEntityTypeConfiguration<RentInvoice>
    {
        public void Configure(EntityTypeBuilder<RentInvoice> builder)
        {
            builder.ToTable("RentInvoices");

            builder.HasKey(r => r.Id);

            builder.Property(r => r.RentInvoiceNumber)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(40);

            builder.HasOne(r => r.Customer)
                   .WithMany(c => c.RentInvoices)
                   .HasForeignKey(r => r.CustomerId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.Property(r => r.TotalAmount)
                 .HasPrecision(18, 2);

            builder.Property(r => r.DiscountAmount)
                   .HasPrecision(18, 2);

            builder.HasOne(r => r.PaymentMethod)
                   .WithMany(p => p.RentInvoices)
                   .HasForeignKey(r => r.PaymentMethodId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.Property(r => r.SellerName)
                     .IsRequired()
                     .HasMaxLength(100);

            builder.Property(r => r.Description)
                        .HasMaxLength(500);

            
        }
    }
}
