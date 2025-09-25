using MediatR;
using Trello.WebApi.Context;

namespace Trello.WebApi.Commands.Board.Delete;

public class DeleteBoardCommandHandler(ApplicationDbContext dbContext) : IRequestHandler<DeleteBoardCommand>
{
    public async Task Handle(DeleteBoardCommand request, CancellationToken cancellationToken)
    {
        var board = await dbContext.FindAsync<Domain.Entities.Board>(request.Id);
        ArgumentNullException.ThrowIfNull(board);
        dbContext.Remove(board);
        await dbContext.SaveChangesAsync(cancellationToken);
    }
}