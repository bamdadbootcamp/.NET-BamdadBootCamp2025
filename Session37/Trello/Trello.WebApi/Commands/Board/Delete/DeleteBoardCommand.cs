using MediatR;

namespace Trello.WebApi.Commands.Board.Delete;
// {
//     public class DeleteBoardCommand : IRequest
//     {
//         public long BoardId { get; set; }
//     }
// }

public record DeleteBoardCommand(long Id) : IRequest;
