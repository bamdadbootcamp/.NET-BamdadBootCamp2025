// using MediatR;
// using Trello.WebApi.Context;
//
// namespace Trello.WebApi.Commands.Board.Delete
// {
//     public class DeleteBoardCommandHandler : IRequestHandler<DeleteBoardCommand>
//     {
//         #region [- Fields -]
//         private readonly ApplicationDbcontext _dbcontext;
//         #endregion
//
//         #region [- Ctor -]
//         public DeleteBoardCommandHandler(ApplicationDbcontext dbcontext)
//         {
//             _dbcontext = dbcontext;
//         }
//         #endregion
//
//         #region [- Handle -]
//         public async Task Handle(DeleteBoardCommand request, CancellationToken cancellationToken)
//         {
//             var board =await _dbcontext.FindAsync<Domain.Entities.Board>(request.Id);
//              if (board != null) {
//                  _dbcontext.Remove(board);
//                 await _dbcontext.SaveChangesAsync();
//             }
//             else
//             {
//                 throw new Exception("The operation can not be done!");
//             }  
//         } 
//         #endregion
//     }
// }
//
