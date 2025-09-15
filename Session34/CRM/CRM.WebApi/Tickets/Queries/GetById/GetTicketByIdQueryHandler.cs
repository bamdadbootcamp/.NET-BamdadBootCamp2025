using CRM.WebApi.Tickets.Dto;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CRM.WebApi.Tickets.Queries.GetById;

public class GetTicketByIdQueryHandler(ApplicationDbContext dbContext)
    : IRequestHandler<GetTicketByIdQuery, GetTicketDto>
{
    public async Task<GetTicketDto> Handle(GetTicketByIdQuery request, CancellationToken cancellationToken)
    {
        var ticket = await dbContext.Tickets.Include(i => i.Chats)
            .FirstOrDefaultAsync(f => f.Id == request.TicketId, cancellationToken);

        if (ticket is null) throw new Exception("Ticket not found");

        var dto = new GetTicketDto
        {
            Subject = ticket.Subject,
            CreatedByUserId = ticket.CreatedByUserId,
            Status = ticket.Status,
        };
        foreach (var chat in ticket.Chats)
        {
            dto.Chats.Add(new GetChatDto()
            {
                CreatedByUserId = chat.CreatedByUserId,
                CreatedOn = chat.CreationOn,
                Message = chat.Message,
                TicketId = chat.TicketId
            });
        }

        return dto;
    }
}