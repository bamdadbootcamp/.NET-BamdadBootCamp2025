
using ShopApp.Domain.Base;

namespace ShopApp.Domain.Entities;

public class InvoiceDetail : BaseEntity
{
    public Invoice Invoice { get; private set; }
    public long InvoiceId { get; private set; }
    public Product Product { get; private set; }
    public long ProductId { get; private set; }
    public int Quantity { get; private set; }
    public decimal Price { get; private set; }
}