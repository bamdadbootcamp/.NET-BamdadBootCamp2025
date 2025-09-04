using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.DAL.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Addresses");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Country)
                .IsRequired()
                   .HasMaxLength(50);

            builder.Property(a => a.PostalCode)
                .IsRequired()
                   .HasMaxLength(20);

            builder.Property(a => a.FullAddress)
                .IsRequired()                
                   .HasMaxLength(500);
            builder.Property(a => a.City)
                .IsRequired()
                .HasConversion<int>();

            builder.Property(a => a.Description)
                   .HasMaxLength(500);
            builder.HasOne(a => a.Customer)
                .WithMany(c => c.Addresses)
                .HasForeignKey(a => a.CustomerId)
                .OnDelete(DeleteBehavior.Cascade );
        }
    }
}
