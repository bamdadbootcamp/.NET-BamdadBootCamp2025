using MediatR;

namespace Trello.WebApi.Commands.List.Update
{
    public class UpdateListCommand : IRequest
    {
        public long ListId { get; set; }
        public string Title { get; set; }
    }
}
