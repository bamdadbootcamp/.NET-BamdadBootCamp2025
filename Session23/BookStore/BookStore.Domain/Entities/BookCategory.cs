using BookStore.Domain.Entities.Core;

namespace BookStore.Domain.Entities;

public class BookCategory : BaseEntity
{
    public string Title { get; set; }
    public int Test { get; set; }

    public ICollection<Book> Books { get; set; }
}
