using BookStore.Domain.Entities.Core;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace BookStore.Domain.Entities;

public class Book : BaseEntity
{
    private Book()
    {
    }
    public static Book Create(string name
        , decimal price
        , int pageCount
        , string isbn
        , int publisherId)
    {
        return new Book
        {
            Name = name,
            Price = price,
            PageCount = pageCount,
            ISBN = isbn,
            PublishDate = DateOnly.FromDateTime(DateTime.Now),
            PublisherId = publisherId
        };
    }

    public string Name { get; private set; }

    public decimal Price { get; private set; }

    public decimal? RentPricePerDay { get; private set; }
    public decimal? FinePricePerDay { get; private set; }
    public int PageCount { get; private set; }
    public string ISBN { get; private set; }
    public DateOnly PublishDate { get; private set; }


    public int PublisherId { get; set; } // FK
    public Publisher Publisher { get; set; } // Navigation property

    public int CategoryId { get; set; }
    public BookCategory Category { get; set; }

    public void UpdatePrice(decimal newPrice)
    {
        Price = newPrice;

    }
    public void UpdateName(string name)
    {
        if (string.IsNullOrEmpty(name))
            throw new ArgumentNullException("name");
        if (name.Length < 1)
            throw new ArgumentNullException("name");

        Name = name;
    }
}
