using MediatR;

namespace Trello.WebApi.Commands.Issue.Create
{
    public class CreateIssueCommand : IRequest<long>
    {
        #region [- Props -]
        public string Title { get; set; }
        public string Description { get; set; }
        public long ListId { get; set; }
        #endregion
    }
}
