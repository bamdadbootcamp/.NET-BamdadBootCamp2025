using MediatR;
using Trello.WebApi.Context;

namespace Trello.WebApi.Commands.List.Create
{
    public class CreateListCommandHandler : IRequestHandler<CreateListCommand, long>
    {
        #region [- Fields -]
        private readonly ApplicationDbContext _dbcontext;
        #endregion

        #region [- Ctor -]
        public CreateListCommandHandler(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        } 
        #endregion

        #region [- Handle -]
        public async Task<long> Handle(CreateListCommand request, CancellationToken cancellationToken)
        {
            var list = Domain.Entities.List.Create(request.BoardId,request.Title);
            await _dbcontext.AddAsync(list);
            await _dbcontext.SaveChangesAsync();
            return list.Id;
        } 
        #endregion
    }
}
