using Trello.WebApi.Domain.Entities.Core;

namespace Trello.WebApi.Domain.Entities
{
    public class List : BaseEntityType
    {
        private List()
        {
        }

        public Board Board { get; private set; }
        public long BoardId { get; private set; }
        public string Title { get; private set; }
        public ICollection<Issue> Issues { get;private set; }

        public static List Create(long boardId, string title)
        {
            return new List()
            {
                BoardId = boardId,
                Title = title
            };
        }

        public void Update(string title)
        {
            if (!string.IsNullOrEmpty(title))
                Title = title;
        } 
    }
}
