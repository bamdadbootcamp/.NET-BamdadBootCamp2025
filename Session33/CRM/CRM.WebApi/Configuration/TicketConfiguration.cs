using CRM.WebApi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.WebApi.Configuration;

public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
{
    public void Configure(EntityTypeBuilder<Ticket> builder)
    {
        builder.Property(p => p.Status)
            .IsRequired();

        builder.Property(p => p.Subject)
            .IsRequired()
            .HasMaxLength(128);

        builder.HasOne(o => o.CreatedByUser)
            .WithMany(m => m.Tickets)
            .HasForeignKey(f => f.CreatedByUserId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);
    }
}