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
    public class CustomerTypeConfiguration : IEntityTypeConfiguration<CustomerType>
    {
        public void Configure(EntityTypeBuilder<CustomerType> builder)
        {
            builder.ToTable("CustomerTypes");

            builder.HasKey(ct => ct.Id);

            builder.Property(ct => ct.Title)
                   .IsRequired()
                   .HasMaxLength(50);
        }
    }
}
