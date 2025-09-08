using CRM.WebApi.Base;
using CRM.WebApi.Enums;

namespace CRM.WebApi.Entities;

public class Ticket : BaseEntity
{
    public TicketStatus Status { get; private set; }
    public string Subject { get; private set; }
    public User CreatedByUser { get; private set; }
    public Ulid CreatedByUserId { get; private set; }
    public ICollection<Chat> Chats { get; private set; }

    public static Ticket Create(Ulid userId, string subject, string message)
    {
        var ticket = new Ticket()
        {
            CreatedByUserId = userId,
            Subject = subject,
            Chats = new List<Chat>()
        };
        ticket.AddChat(Chat.Create(userId, ticket.Id, message));
        return ticket;
    }

    public void AddChat(Chat chat)
    {
        if (Status == TicketStatus.Closed)
            throw new Exception("Ticket is closed");
        Chats.Add(chat);
    }

    public void MarkAsInProgress()
    {
        if (Status == TicketStatus.Closed)
            throw new Exception("Ticket is closed");
        Status = TicketStatus.InProgress;
    }

    public void MarkAsDone()
    {
        if (Status == TicketStatus.Closed)
            throw new Exception("Ticket is closed");
        Status = TicketStatus.Closed;
    }

    private Ticket()
    {
        Id = Ulid.NewUlid();
        Status = TicketStatus.Open;
        Chats = new List<Chat>();
    }
}