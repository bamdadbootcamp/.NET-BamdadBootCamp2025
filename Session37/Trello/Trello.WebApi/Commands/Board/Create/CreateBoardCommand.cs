using MediatR;

namespace Trello.WebApi.Commands.Board.Create;

public record CreateBoardCommand(string Title) : IRequest<long>;
