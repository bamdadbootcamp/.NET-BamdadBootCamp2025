using CRM.WebApi.Base;
using CRM.WebApi.Enums;

namespace CRM.WebApi.Entities;

public class User : BaseEntity
{
    public string Username { get; private set; } 
    public string Password { get; private set; }
    public UserType UserType { get; private set; }
    public ICollection<Chat> Chats { get; private set; }
    public ICollection<Ticket> Tickets { get; private set; }

    public static User CreateUser(string username, string password)
    {
        return new User()
        {
            Username = username,
            Password = password,
            UserType = UserType.User,
        };
    }
    
    public static User CreateAdmin(string username, string password)
    {
        return new User()
        {
            Username = username,
            Password = password,
            UserType = UserType.Admin,
        };
    }

    public User()
    {
        Id = Ulid.NewUlid();
    }
}