using BookStore.Domain.Entities.Core;

namespace BookStore.Domain.Entities;

public class BookCategory : BaseEntity
{
    public BookCategory()
    {
        Id = Ulid.NewUlid();
    }
    public string Title { get; set; }
}
