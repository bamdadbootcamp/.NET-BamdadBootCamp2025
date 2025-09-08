using CRM.WebApi.Entities;
using CRM.WebApi.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CRM.WebApi.Tickets.Commands.AddChat;

public class AddChatCommandHandler(ApplicationDbContext dbContext) : IRequestHandler<AddChatCommand>
{
    public async Task Handle(AddChatCommand request, CancellationToken cancellationToken)
    {
        var ticket = await dbContext.Tickets
            .FirstOrDefaultAsync(f => f.Id == request.TicketId, cancellationToken);

        var user = await dbContext.Users
            .FirstOrDefaultAsync(f => f.Id == request.UserId, cancellationToken);

        if (ticket is null) throw new Exception("Ticket not found");

        if (user is null) throw new Exception("User not found");

        var chat = Chat.Create(request.UserId, request.TicketId, request.Message);

        if (ticket.Status == TicketStatus.Open && user.UserType == UserType.Admin)
            ticket.MarkAsInProgress();

        ticket.AddChat(chat);

        dbContext.Update(ticket);

        await dbContext.SaveChangesAsync(cancellationToken);
    }
}