using BookStore.BL.Dto;
using BookStore.Domain.Entities;

namespace BookStore.BL.Services;

public static class PublisherService
{
    private static List<Publisher> _publishers = new List<Publisher>();
    public static void Create(string title)
    {
        var book = Publisher.Create(title);
        _publishers.Add(book);
    }

    public static List<Publisher> GetAll() => _publishers;

    public static Publisher? Find(Ulid id)
    {
        var publisher = _publishers.SingleOrDefault(s => s.Id == id);
        return publisher;
    }

    public static void Update(Publisher invoice)
    {

    }

}
