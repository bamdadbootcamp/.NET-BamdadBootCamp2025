namespace Framework.Core.Base;

public abstract class BaseEntity<TKey> where TKey : struct
{
    public TKey Id { get; set; }
    public DateTimeOffset CreatedAt { get; set; } = DateTime.Now;
    public bool IsArchived { get; set; } = false;
    public DateTimeOffset? LastModifiedAt { get; set; } = null;
}

public abstract class BaseEntity : BaseEntity<long>;