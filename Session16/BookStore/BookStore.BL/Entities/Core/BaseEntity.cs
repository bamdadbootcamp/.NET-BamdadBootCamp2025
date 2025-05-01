namespace BookStore.BL.Entities.Core;

public abstract class BaseEntity
{
    public BaseEntity()
    {
        CreatedOn = DateTime.Now;
        IsDeleted = false;
    }
    public int Id { get; }
    public DateTime CreatedOn { get; }
    public DateTime? LastModifiedDate { get; set; }
    public bool IsDeleted { get; set; }

    //public abstract int Sum(int num1, int num2);
    
    //public int Sum(int num1, int num2)
    //    => num1 + num2;
}
