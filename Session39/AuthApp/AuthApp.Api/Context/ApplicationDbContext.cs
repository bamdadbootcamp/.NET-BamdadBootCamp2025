using System.Reflection;
using AuthApp.Api.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthApp.Api.Context;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<User, Role, string>(options)
{
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }

}