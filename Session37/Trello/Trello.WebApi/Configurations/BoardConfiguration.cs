using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Trello.WebApi.Domain.Entities;

namespace Trello.WebApi.Configurations;

public class BoardConfiguration : IEntityTypeConfiguration<Board>
{
    public void Configure(EntityTypeBuilder<Board> builder)
    {
        builder.ToTable(nameof(Board));

        builder.Property(x => x.Title)
            .IsRequired()
            .HasMaxLength(64);

        // builder.HasIndex(i => new { i.Title, i.UserId })
        //     .IsUnique();

        builder.HasMany(b => b.Lists)
            .WithOne(b => b.Board)
            .HasForeignKey(b => b.BoardId);
    }
}