using MediatR;
using Trello.WebApi.Context;

namespace Trello.WebApi.Commands.Issue.Update
{
    public class UpdateIssueCommandHandler : IRequestHandler<UpdateIssueCommand>
    {
        #region [- Fields -]

        private readonly ApplicationDbContext _dbcontext;

        #endregion

        #region [- Ctor -]

        public UpdateIssueCommandHandler(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        #endregion

        #region [- Handle -]

        public async Task Handle(UpdateIssueCommand request, CancellationToken cancellationToken)
        {
            var issue = await _dbcontext.FindAsync<Domain.Entities.Issue>(request.IssueId);
            if (issue != null)
            {
                issue.Update(request.Title, request.Description, request.ListId);

                await _dbcontext.SaveChangesAsync(cancellationToken);
            }
            else
            {
                throw new Exception("The operation can not be done!");
            }
        }

        #endregion
    }
}