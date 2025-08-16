using Framework.Core.Base;

namespace ShopApp.Domain.Entities;

public class ProductCategory : BaseEntity
{
    public string Title { get; private set; }

    public ICollection<Product> Products { get; private set; }
}