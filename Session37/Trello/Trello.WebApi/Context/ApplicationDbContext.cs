using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Trello.WebApi.Domain.Entities;

namespace Trello.WebApi.Context
{
    public class ApplicationDbContext : DbContext
    {
        #region [- Ctor -]
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        #endregion

        #region [- Props -]
        public DbSet<Issue> Issues { get; set; }
        public DbSet<Board> Boards { get; set; }
        public DbSet<List> Lists { get; set; }      
        #endregion

        #region [- OnModelCreating(ModelBuilder modelBuilder) -]
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        #endregion
    }
}
