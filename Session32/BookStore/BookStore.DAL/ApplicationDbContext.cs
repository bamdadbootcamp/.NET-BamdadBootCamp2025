using BookStore.DAL.Configurations;
using BookStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace BookStore.DAL;

public class ApplicationDbContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<BookCategory> BookCategories { get; set; }
    public DbSet<Publisher> Publishers { get; set; }

    private static readonly string _connectionstring = "Server=.;Initial catalog=BookStore;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

    // Server : Database address => localhost | . | IP
    // Initial Catalog or Database : database name
    // Auth : 
    // Username & Password : User Id=.....      Password=.....
    // Windows Auth : Integrated Security=true


    public ApplicationDbContext() : base(new DbContextOptionsBuilder<ApplicationDbContext>()
                                            .UseSqlServer(_connectionstring).Options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration<Book>(new BookConfiguration());
        modelBuilder.ApplyConfiguration<BookCategory>(new BookCategoryConfiguration());
        modelBuilder.ApplyConfiguration<Publisher>(new PublisherConfiguration());
    }

}
