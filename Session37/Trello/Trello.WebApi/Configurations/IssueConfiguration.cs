using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Trello.WebApi.Domain.Entities;

namespace Trello.WebApi.Configurations;

public class IssueConfiguration : IEntityTypeConfiguration<Issue>
{
    public void Configure(EntityTypeBuilder<Issue> builder)
    {
        builder.ToTable(nameof(Issue));
        
        builder.Property(x => x.Title)
            .IsRequired()
            .HasMaxLength(64);
        
        builder.Property(x => x.Description)
            .IsRequired()
            .HasMaxLength(128);
    }
}