using MediatR;
using Trello.WebApi.Commands.Board.Create;
using Trello.WebApi.Context;

namespace Trello.WebApi.Commands.Issue.Create
{
    public class CreateIssueCommandHandler : IRequestHandler<CreateIssueCommand, long>
    {
        #region [- Fields -]
        private readonly ApplicationDbContext _dbcontext;
        #endregion

        #region [- Ctor -]
        public CreateIssueCommandHandler(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        } 
        #endregion

        #region [- Handle -]
        public async Task<long> Handle(CreateIssueCommand request, CancellationToken cancellationToken)
        {
            var issue = Domain.Entities.Issue.Create(request.Title,request.Description,request.ListId);
            await _dbcontext.AddAsync(issue);
            await _dbcontext.SaveChangesAsync();
            return issue.Id;
        } 
        #endregion
    }
}
