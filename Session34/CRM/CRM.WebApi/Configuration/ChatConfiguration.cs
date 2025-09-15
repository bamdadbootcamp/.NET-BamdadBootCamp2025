using CRM.WebApi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.WebApi.Configuration;

public class ChatConfiguration : IEntityTypeConfiguration<Chat>
{
    public void Configure(EntityTypeBuilder<Chat> builder)
    {
        builder.HasOne(o => o.CreatedByUser)
            .WithMany(m => m.Chats)
            .HasForeignKey(f => f.CreatedByUserId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasOne(o => o.Ticket)
            .WithMany(m => m.Chats)
            .HasForeignKey(f => f.TicketId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(p => p.Message)
            .IsRequired()
            .HasMaxLength(1024);
    }
}