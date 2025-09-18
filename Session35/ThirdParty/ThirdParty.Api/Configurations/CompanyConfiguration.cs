using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ThirdParty.Api.Entities;

namespace ThirdParty.Api.Configurations;

public class CompanyConfiguration : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder.ToTable("Companies");
        
        builder.Property(p => p.Name)
            .HasMaxLength(100)
            .IsRequired();
        
        builder.Property(p => p.CompanyKey)
            .IsRequired();
        
        builder.Property(p => p.IpAddress)
            .HasMaxLength(15)
            .IsRequired();

        builder.HasIndex(i => new { i.IpAddress, i.CompanyKey })
            .IsUnique();
    }
}