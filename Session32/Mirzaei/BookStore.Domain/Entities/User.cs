
using BookStore.Domain.Core;
namespace BookStore.Domain.Entities;

public class User : BaseEntity
{
    public string UserName { get; set; }
    public string Password { get; set; }
}
