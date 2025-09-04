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
    public class InvoiceItemConfiguration : IEntityTypeConfiguration<InvoiceItem>
    {
        public void Configure(EntityTypeBuilder<InvoiceItem> builder)
        {
            builder.ToTable("InvoiceItems");

            builder.HasKey(ii => ii.Id);

            builder.HasOne(ii => ii.Book)
                   .WithMany(b => b.InvoiceItems)
                   .HasForeignKey(ii => ii.BookId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.Property(ii => ii.UnitPrice)
                   .HasPrecision(18, 2);

            builder.Property(ii => ii.TotalPrice)
                   .HasPrecision(18, 2);

            builder.HasOne(ii => ii.RentInvoice)
                   .WithMany(ri => ri.InvoiceItems)
                   .HasForeignKey(ii => ii.RentInvoiceId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(ii => ii.SaleInvoice)
                   .WithMany(si => si.InvoiceItems)
                   .HasForeignKey(ii => ii.SaleInvoiceId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
