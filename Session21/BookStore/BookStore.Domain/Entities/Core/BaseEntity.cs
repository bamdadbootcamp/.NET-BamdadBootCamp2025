namespace BookStore.Domain.Entities.Core;

public abstract class BaseEntity<TKey>
{
    public BaseEntity()
    {
        CreatedOn = DateTime.Now;
        IsArchived = false;
    }
    public TKey Id { get; protected set; }
    public DateTime CreatedOn { get; }
    public DateTime? LastModifiedDate { get; set; }
    public bool IsArchived { get; set; }

    //public abstract int Sum(int num1, int num2);
    
    //public int Sum(int num1, int num2)
    //    => num1 + num2;
}

public abstract class BaseEntity : BaseEntity<Ulid>;