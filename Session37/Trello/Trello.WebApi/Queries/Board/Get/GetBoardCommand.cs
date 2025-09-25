using MediatR;
using Microsoft.EntityFrameworkCore;
using Trello.WebApi.Context;
using Trello.WebApi.Dtos;

namespace Trello.WebApi.Queries.Board.Get;

public record GetBoardQuery(int PageNumber = 1, int PageSize = 10) : IRequest<IEnumerable<GetBoardDto>>;

public class GetBoardQueryHandler(ApplicationDbContext dbContext) :  IRequestHandler<GetBoardQuery, IEnumerable<GetBoardDto>>
{
    public async Task<IEnumerable<GetBoardDto>> Handle(GetBoardQuery request, CancellationToken cancellationToken)
    {
        var skip = (request.PageNumber - 1) * request.PageSize;

        var query = await dbContext.Boards
            .AsNoTracking()
            .OrderByDescending(o => o.CreationOn)
            .Skip(skip)
            .Take(request.PageSize)
            .Select(s => new GetBoardDto
            {
                Id = s.Id,
                Title = s.Title,
            })
            .ToListAsync(cancellationToken);

        return query;
    }
}