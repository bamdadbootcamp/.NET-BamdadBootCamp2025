using CRM.WebApi.Tickets.Dto;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CRM.WebApi.Tickets.Queries.GetPaginated;

public class GetTicketsPaginatedQueryHandler(ApplicationDbContext dbContext)
    : IRequestHandler<GetTicketsPaginatedQuery, IEnumerable<GetTicketDto>>
{
    public async Task<IEnumerable<GetTicketDto>> Handle(GetTicketsPaginatedQuery request,
        CancellationToken cancellationToken)
    {
        var query = dbContext.Tickets.AsNoTracking()
            .OrderByDescending(d => d.CreationOn);

        var items = await query
            .Skip((request.PageNumber - 1) * request.PageSize)
            .Take(request.PageSize)
            .Select(s => new GetTicketDto
            {
                Subject = s.Subject,
                CreatedByUserId = s.CreatedByUserId,
                Status = s.Status,
            })
            .ToListAsync(cancellationToken);

        return items;
    }
}