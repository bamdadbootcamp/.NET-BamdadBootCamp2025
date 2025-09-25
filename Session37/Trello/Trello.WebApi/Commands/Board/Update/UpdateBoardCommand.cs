using MediatR;

namespace Trello.WebApi.Commands.Board.Update;

public record UpdateBoardCommand(string Id, string Title) : IRequest<Unit>;
