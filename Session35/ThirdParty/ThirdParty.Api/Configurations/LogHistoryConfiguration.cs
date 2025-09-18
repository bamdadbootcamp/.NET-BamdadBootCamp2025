using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ThirdParty.Api.Entities;

namespace ThirdParty.Api.Configurations;

public class LogHistoryConfiguration : IEntityTypeConfiguration<LogHistory>
{
    public void Configure(EntityTypeBuilder<LogHistory> builder)
    {
        builder.ToTable("LogHistory");

        builder.Property(o => o.Operation)
            .IsRequired();
        
        builder.Property(o => o.OperationResult)
            .IsRequired();

        builder.Property(p => p.RequestedIpAddress)
            .HasMaxLength(15)
            .IsRequired();
        
        builder.Property(p => p.RequestedBodyJson)
            .HasMaxLength(1024)
            .IsRequired(false);

        builder.HasOne(o => o.Company)
            .WithMany(m => m.LogHistories)
            .HasForeignKey(f => f.CompanyId)
            .IsRequired(false);

    }
}