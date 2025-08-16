namespace BankManagement.Domain.Base;

public abstract class BaseEntity<TKey> where TKey : struct
{
    public TKey Id { get; set; }
    public DateTime CreatedAt { get; set; }
}

public abstract class BaseEntity : BaseEntity<long>;