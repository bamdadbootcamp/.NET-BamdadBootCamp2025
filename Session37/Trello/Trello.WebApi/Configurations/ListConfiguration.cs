using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Trello.WebApi.Domain.Entities;

namespace Trello.WebApi.Configurations;

public class ListConfiguration : IEntityTypeConfiguration<List>
{

    public void Configure(EntityTypeBuilder<List> builder)
    {
        builder.ToTable(nameof(List));

        builder.Property(x => x.Title)
            .IsRequired()
            .HasMaxLength(64);

        builder.HasMany(issue => issue.Issues)
            .WithOne(list => list.List)
            .HasForeignKey(list => list.ListId);
    }

}