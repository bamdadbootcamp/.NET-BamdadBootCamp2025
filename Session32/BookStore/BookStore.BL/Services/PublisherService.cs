using BookStore.BL.Dto;
using BookStore.DAL;
using BookStore.Domain.Entities;

namespace BookStore.BL.Services;

public static class PublisherService
{
    private static List<Publisher> _publishers = new List<Publisher>();
    public static void Create(string title)
    {
        var publisher = Publisher.Create(title);

        ApplicationDbContext context = new ApplicationDbContext();

        context.Publishers.Add(publisher);
        context.SaveChanges();

        _publishers.Add(publisher);
    }

    public static List<Publisher> GetAll()
    {
        ApplicationDbContext context = new ApplicationDbContext();
        var publishers = _publishers.ToList();

        return _publishers;
    }

    //public static Publisher? Find(Ulid id)
    //{
    //    //var publisher = _publishers.SingleOrDefault(s => s.Id == id);
    //    //return publisher;
    //}

    public static void Update(Publisher invoice)
    {

    }

}
