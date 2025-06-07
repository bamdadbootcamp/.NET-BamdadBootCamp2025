using BookStore.Domain.Entities.Core;

namespace BookStore.Domain.Entities;

public class Publisher : BaseEntity
{
    private Publisher()
    {
    }

    public static Publisher Create(string Title)
    {
        return new Publisher() { Title = Title };
    }

    public string Title { get; set; }

    public ICollection<Book> Books { get; set; } // Navigation property
}
