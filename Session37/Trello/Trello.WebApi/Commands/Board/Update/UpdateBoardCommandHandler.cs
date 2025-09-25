using MediatR;
using Trello.WebApi.Context;

namespace Trello.WebApi.Commands.Board.Update;

public class UpdateBoardCommandHandler(ApplicationDbContext dbContext) : IRequestHandler<UpdateBoardCommand, Unit>
{
    public async Task<Unit> Handle(UpdateBoardCommand request, CancellationToken cancellationToken)
    {
        var board = await dbContext.FindAsync<Domain.Entities.Board>(request.Id);
        ArgumentNullException.ThrowIfNull(board);
        board.Update(request.Title);
        await dbContext.SaveChangesAsync(cancellationToken);
        return Unit.Value;
    }
}