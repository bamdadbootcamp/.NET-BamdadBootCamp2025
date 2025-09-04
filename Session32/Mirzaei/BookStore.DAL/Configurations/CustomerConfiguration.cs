using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace BookStore.DAL.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.FirstName)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(c => c.LastName)
                   .IsRequired()
                   .HasMaxLength(100);           

            builder.Property(c => c.NationalCode)
                .IsRequired()
                   .HasMaxLength(20);

            builder.HasIndex(c => c.NationalCode)
                .IsUnique();

            builder.Property(c => c.BirtDate)
                .HasColumnType("date");

            builder.Property(c => c.Gender)
                .HasConversion<int>();

            builder.Property(c => c.Credit)
                   .HasPrecision(18, 2);

            builder.HasOne(c => c.CustomerType)
                   .WithMany(ct => ct.Customers)
                   .HasForeignKey(c => c.CustomerTypeId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
