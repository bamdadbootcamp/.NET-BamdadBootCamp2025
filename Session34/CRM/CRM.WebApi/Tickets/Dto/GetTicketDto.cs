using CRM.WebApi.Entities;
using CRM.WebApi.Enums;

namespace CRM.WebApi.Tickets.Dto;

public class GetTicketDto
{
    public TicketStatus Status { get;  set; }
    public required string Subject { get;  set; }
    public Ulid CreatedByUserId { get;  set; }
    public List<GetChatDto> Chats { get; set; } = new();
}

public class GetChatDto
{
    public DateTimeOffset CreatedOn { get; set; }
    public Ulid CreatedByUserId { get; set; }
    public Ulid TicketId { get; set; }
    public required string Message { get; set; }
}