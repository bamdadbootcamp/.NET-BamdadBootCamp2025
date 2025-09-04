using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BookStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DAL.Contexts
{
    public class ApplicationDbContext : DbContext
    {
  
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerType> CustomerTypes { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<RentInvoice> RentInvoices { get; set; }
        public DbSet<SaleInvoice> SaleInvoices { get; set; }
        public DbSet<User> Users { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());            
        }
    }
}
