namespace ThirdParty.Api.Base;

public abstract class BaseEntity<TKey> where TKey : struct
{
    public TKey Id { get; set; }
    public DateTimeOffset CreationOn { get; set; } = DateTimeOffset.Now;
    public DateTimeOffset? UpdatedOn { get; set; }
    public bool IsArchived { get; set; } =  false;
}

public abstract class BaseEntity : BaseEntity<long>;