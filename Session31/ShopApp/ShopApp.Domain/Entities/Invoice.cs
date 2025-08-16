using Framework.Core.Base;

namespace ShopApp.Domain.Entities;

public class Invoice : BaseEntity
{
    public string Number { get; private set; }
    public DateTimeOffset InvoiceDateTime { get; private set; }
    public User User { get; private set; }
    public long UserId { get; private set; }
    public decimal TotalPrice { get; private set; }
    public int DiscountPercentage { get; private set; }

    public ICollection<InvoiceDetail> InvoiceDetails { get; set; }
}