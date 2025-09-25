using MediatR;

namespace Trello.WebApi.Commands.Issue.Update
{
    public class UpdateIssueCommand : IRequest
    {
        public long IssueId { get; set; }
        public string Title { get;  set; }
        public string Description { get;  set; }
        public long ListId { get; private set; }
    }
}
