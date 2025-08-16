using BankManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BankManagement.DAL.Contexts;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)

    {
    }
    public DbSet<Customer> Customer { get; set; }
    public DbSet<BankAccount> BankAccounts { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}
