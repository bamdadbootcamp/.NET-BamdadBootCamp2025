using MediatR;
using Trello.WebApi.Context;

namespace Trello.WebApi.Commands.Board.Create;

public class CreateBoardCommandHandler(ApplicationDbContext dbContext) : IRequestHandler<CreateBoardCommand, long>
{
    public async Task<long> Handle(CreateBoardCommand request, CancellationToken cancellationToken)
    {
        var board = Domain.Entities.Board.Create(request.Title);
        await dbContext.AddAsync(board, cancellationToken);
        await dbContext.SaveChangesAsync(cancellationToken);
        return board.Id;
    }
}