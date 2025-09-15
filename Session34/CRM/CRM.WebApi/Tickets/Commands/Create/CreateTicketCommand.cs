using MediatR;

namespace CRM.WebApi.Tickets.Commands.Create;

public record CreateTicketCommand(Ulid UserId, string Subject, string Message) : IRequest;