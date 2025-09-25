using MediatR;

namespace Trello.WebApi.Commands.Issue.Delete
{
    public class DeleteIssueCommand : IRequest
    {
        public long IssueId { get; set; }
    }
}
