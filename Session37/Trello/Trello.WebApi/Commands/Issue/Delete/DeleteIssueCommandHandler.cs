using MediatR;
using Trello.WebApi.Context;

namespace Trello.WebApi.Commands.Issue.Delete
{
    public class DeleteIssueCommandHandler : IRequestHandler<DeleteIssueCommand>
    {
        #region [- Fields -]
        private readonly ApplicationDbContext _dbcontext;
        #endregion

        #region [- Ctor -]
        public DeleteIssueCommandHandler(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        } 
        #endregion

        #region [- Handle -]
        public async Task Handle(DeleteIssueCommand request, CancellationToken cancellationToken)
        {
            var issue = await _dbcontext.FindAsync<Domain.Entities.Issue>(request.IssueId);
            if (issue != null)
            {
                _dbcontext.Remove(issue);
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
