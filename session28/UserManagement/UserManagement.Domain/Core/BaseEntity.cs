namespace UserManagement.Domain.Core;

public abstract class BaseEntity<TKey> where TKey : struct
{
    public TKey Id { get; protected set; }
    public DateTime CreatedOn { get; protected set; } = DateTime.Now;
    public DateTime? LastModifiedDateTime { get; protected set; }
    public bool IsArchived { get; protected set; } = false;
}

public abstract class BaseEntity : BaseEntity<long>;