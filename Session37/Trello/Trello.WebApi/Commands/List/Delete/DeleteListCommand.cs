
using MediatR;

namespace Trello.WebApi.Commands.List.Delete
{
    public class DeleteListCommand : IRequest
    {
        public long ListId { get; set; }
    }
}
