using MediatR;

namespace CRM.WebApi.Tickets.Commands.CloseTicket;

public record CloseTicketCommand(Ulid TicketId) : IRequest;
