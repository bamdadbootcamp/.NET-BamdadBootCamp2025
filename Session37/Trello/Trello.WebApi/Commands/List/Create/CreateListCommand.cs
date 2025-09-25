using MediatR;

namespace Trello.WebApi.Commands.List.Create
{
    public class CreateListCommand : IRequest<long>
    {
        #region [- Props -]
        public long BoardId { get; set; }
        public string Title { get; set; } 
        #endregion
    }
}
