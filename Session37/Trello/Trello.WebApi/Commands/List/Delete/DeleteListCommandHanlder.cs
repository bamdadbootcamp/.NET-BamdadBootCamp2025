using MediatR;
using Trello.WebApi.Context;

namespace Trello.WebApi.Commands.List.Delete
{
    public class DeleteListCommandHanlder : IRequestHandler<DeleteListCommand>
    {
        #region [- Fields -]
        private readonly ApplicationDbContext _dbcontext;
        #endregion

        #region [- Ctor -]
        public DeleteListCommandHanlder(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        } 
        #endregion

        #region [- Handle -]
        public async Task Handle(DeleteListCommand request, CancellationToken cancellationToken)
        {
            var list = await _dbcontext.FindAsync<Domain.Entities.List>(request.ListId);
            if (list != null)
            {
                _dbcontext.Remove(list);
                await _dbcontext.SaveChangesAsync();
            }
            else
            {
                throw new Exception("The operation can not be done!");
            }
        } 
        #endregion
    }
}
