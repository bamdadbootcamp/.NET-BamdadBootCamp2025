using MediatR;

namespace CRM.WebApi.Tickets.Commands.CloseTicket;

public class CloseTicketCommandHandler(ApplicationDbContext dbContext) : IRequestHandler<CloseTicketCommand>
{
    public async Task Handle(CloseTicketCommand request, CancellationToken cancellationToken)
    {
        var ticket = await dbContext.Tickets.FindAsync(request.TicketId);
        
        ticket.MarkAsDone();
        
        dbContext.Tickets.Update(ticket);
        
        await dbContext.SaveChangesAsync(cancellationToken);
    }
}