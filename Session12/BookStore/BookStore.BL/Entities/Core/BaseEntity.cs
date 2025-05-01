namespace BookStore.BL.Entities.Core;

public class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime LastModifiedDate { get; set; }
    public bool IsDeleted { get; set; }
}
