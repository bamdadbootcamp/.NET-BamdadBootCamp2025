using MediatR;

namespace CRM.WebApi.Tickets.Commands.AddChat;

public record AddChatCommand(Ulid UserId, Ulid TicketId, string Message) : IRequest;

