using BookStore.BL.Dto;
using BookStore.DAL;
using BookStore.Domain.Entities;

namespace BookStore.BL.Services;

public static class BookService
{
    private static List<Book> _books = new List<Book>();
    public static void Create(string name, decimal price, int pageCount, string isbn, int publisherId)
    {
        var book = Book.Create(name, price, pageCount, isbn, publisherId);

        ApplicationDbContext context = new ApplicationDbContext();

        context.Books.Add(book);
        context.SaveChanges();

        //_books.Add(book);
    }

    public static List<GetBookDto> GetAll()
    {
        ApplicationDbContext context = new ApplicationDbContext();


        var books = context.Books.ToList();

        List<GetBookDto> dtos = new List<GetBookDto>();
        foreach (var book in _books)
        {

            //var publisher = PublisherService.Find(book.PublisherId);

            //dtos.Add(new GetBookDto
            //{
            //    Id = book.Id,
            //    Name = book.Name,
            //    Price = book.Price,
            //    FinePricePerDay = book.FinePricePerDay,
            //    ISBN = book.ISBN,
            //    PageCount = book.PageCount,
            //    PublishDate = book.PublishDate,
            //    RentPricePerDay = book.RentPricePerDay,
            //    Publisher = publisher != null ? publisher.Title : string.Empty
            //});
        }
        return dtos;
    }

    public static void Update(Book book)
    {
        var existBook = _books.SingleOrDefault(s => s.Id == book.Id);
        if (existBook is null) return;

        if (existBook.Name != book.Name)
            existBook.UpdateName(book.Name);

    }

    //public static bool Delete(Ulid id)
    //{
    //    //var existBook = _books.SingleOrDefault(s => s.Id == id);
    //    //if (existBook is null) return false;
    //    //_books.Remove(existBook);
    //    //return true;
    //}

}
