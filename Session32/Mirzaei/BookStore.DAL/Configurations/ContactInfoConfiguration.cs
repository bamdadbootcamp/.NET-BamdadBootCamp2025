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
    public class ContactInfoConfiguration : IEntityTypeConfiguration<ContactInfo>
    {
        public void Configure(EntityTypeBuilder<ContactInfo> builder)
        {
            builder.ToTable("ContactInfos");

            builder.HasKey(ci => ci.Id);

            builder.Property(ci => ci.PhoneNumber)
                .IsRequired()
                   .HasMaxLength(20);

            builder.Property(ci => ci.MobileNumber)
                .IsRequired()
                   .HasMaxLength(20);

            builder.Property(ci => ci.Email)
                .IsRequired()
                   .HasMaxLength(254);

            builder.Property(ci => ci.TelegramId)
                   .HasMaxLength(50);

            builder.Property(ci => ci.WhatsAppNumber)
                   .HasMaxLength(20);
            builder.HasOne(ci => ci.Customer)
                .WithOne(c => c.ContactInfo)
                .HasForeignKey<ContactInfo>(ci => ci.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
