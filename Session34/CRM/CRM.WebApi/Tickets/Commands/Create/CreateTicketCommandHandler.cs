using CRM.WebApi.Entities;
using MediatR;

namespace CRM.WebApi.Tickets.Commands.Create;

public class CreateTicketCommandHandler(ApplicationDbContext dbContext) : IRequestHandler<CreateTicketCommand>
{
    public async Task Handle(CreateTicketCommand request, CancellationToken cancellationToken)
    {
        var ticket = Ticket.Create(request.UserId, request.Subject, request.Message);
        dbContext.Tickets.Add(ticket);
        await dbContext.SaveChangesAsync(cancellationToken);
    }
}