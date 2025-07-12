using Microsoft.EntityFrameworkCore;
using System.Reflection;
using UserManagement.DAL.Configurations;
using UserManagement.Domain.Core;
using UserManagement.Domain.Entities;

namespace UserManagement.DAL;

public class ApplicationDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        //modelBuilder.ApplyConfiguration(new UserConfiguration());
        //modelBuilder.ApplyConfigurationsFromAssembly(typeof(BaseEntity).Assembly);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
