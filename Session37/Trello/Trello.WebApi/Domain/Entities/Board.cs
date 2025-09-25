using Trello.WebApi.Domain.Entities.Core;

namespace Trello.WebApi.Domain.Entities
{
    public class Board : BaseEntityType
    {
        private Board()
        {
        }

        public string Title { get; private set; }
        // public long UserId { get; set; }
        public ICollection<List> Lists { get; set; }

        public static Board Create(string title)
        {
            return new Board()
            {
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
