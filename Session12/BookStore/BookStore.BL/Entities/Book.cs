using BookStore.BL.Entities.Core;

namespace BookStore.BL.Entities;

public class Book : BaseEntity
{ 
    public Book(string name
        , decimal price
        , int pageCount
        , string isbn
        , DateOnly publishDate)
    {
        Name = name;
        Price = price;
        PageCount = pageCount;
        ISBN = isbn;
        PublishDate = publishDate;
    }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public decimal? RentPricePerDay { get; set; }
    public decimal? FinePricePerDay { get; set; }
    public int PageCount { get; set; }
    public string ISBN { get; set; }
    public DateOnly PublishDate { get; set; }
    // CRUD => Create - Read - Update - Delete
   
}
