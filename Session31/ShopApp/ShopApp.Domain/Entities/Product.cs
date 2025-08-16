using Framework.Core.Base;

namespace ShopApp.Domain.Entities;

public class Product : BaseEntity
{
    public string Title { get; private set; }
    public decimal Price { get; set; }
    public ProductCategory ProductCategory { get; private set; }
    public long ProductCategoryId { get; private set; }

    public ICollection<InvoiceDetail> InvoiceDetails { get; private set; }
}