using BookStore.BL.Entities.Core;
using System.Runtime.CompilerServices;

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

    public decimal Price { get; private set; }

    public decimal? RentPricePerDay { get; set; }
    public decimal? FinePricePerDay { get; set; }
    public int PageCount { get; set; }
    public string ISBN { get; set; }
    public DateOnly PublishDate { get; set; }

    public void UpdatePrice(decimal newPrice)
    {
        Price = newPrice;

        // step 3 : important 
        if (BookPriceUpdatedEvent != null)
            BookPriceUpdatedEvent(Name, newPrice);
    }

    // step 1 : delegate (استاندارد متد)
    public delegate int OnUpdatePrice(string bookName, decimal newPrice);


    // step 2: event
    public event OnUpdatePrice BookPriceUpdatedEvent;
}
