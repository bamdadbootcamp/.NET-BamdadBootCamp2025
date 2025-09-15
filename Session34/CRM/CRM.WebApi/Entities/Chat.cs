using CRM.WebApi.Base;

namespace CRM.WebApi.Entities;

public class Chat : BaseEntity
{
    public User CreatedByUser { get; private set; }
    public Ulid CreatedByUserId { get; private set; }
    public Ticket Ticket { get; private set; }
    public Ulid TicketId { get; private set; }
    public string Message { get; private set; }

    public static Chat Create(Ulid userId, Ulid ticketId, string message)
    {
        return new Chat()
        {
            CreatedByUserId = userId,
            TicketId = ticketId,
            Message = message,
        };
    }
    
    private Chat()
    {
        Id = Ulid.NewUlid();
    }
}