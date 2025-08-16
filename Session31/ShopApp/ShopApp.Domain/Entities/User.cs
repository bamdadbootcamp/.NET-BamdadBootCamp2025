using Framework.Core.Base;

namespace ShopApp.Domain.Entities;

public class User : BaseEntity
{
    public string Username { get; private set; }
    public string Password { get; private set; }
    public bool IsLocked { get; private set; }
    public DateTimeOffset? LastLoginDateTime { get; private set; }
    public ICollection<Invoice> Invoices { get; set; }
}