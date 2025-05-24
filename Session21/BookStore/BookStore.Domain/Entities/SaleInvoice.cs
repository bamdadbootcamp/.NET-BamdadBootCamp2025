using BookStore.Domain.Entities.Core;
using BookStore.Domain.Entities.Enums;

namespace BookStore.Domain.Entities;

public class SaleInvoice : BaseEntity
{
    // SOLID 
    // Single Responsibility Principle
    private SaleInvoice()
    {
        Id = Ulid.NewUlid();
    }
    public string Number { get; private set; }
    public DateTime InvoiceDateTime { get; private set; }
    public List<InvoiceDetail> InvoiceDetails { get; private set; } = new();
    public decimal TotalPrice { get; private set; }

    public static SaleInvoice Create()
    {
        return new SaleInvoice
        {
            Number = $"S-{100}",
            InvoiceDateTime = DateTime.Now,
        };
    }
    public void AddDetail(InvoiceDetail detail)
    {
        if (detail is null)
            return;
        InvoiceDetails.Add(detail);
        TotalPrice += detail.Price;
    }
}
