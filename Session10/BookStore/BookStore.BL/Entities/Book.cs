using BookStore.BL.Entities.Core;

namespace BookStore.BL.Entities;

public class Book : BaseEntity
{ 
    public Book()
    {
    }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int PageCount { get; set; }
    public string ISBN { get; set; }
    public DateOnly PublishDate { get; set; }

    public int BookCategoryId { get; set; }
    public int PublisherId { get; set; }
}
