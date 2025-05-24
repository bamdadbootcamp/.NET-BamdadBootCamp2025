using BookStore.Domain.Entities.Core;

namespace BookStore.Domain.Entities;

public class InvoiceDetail : BaseEntity
{
    private InvoiceDetail()
    {
        Id = Ulid.NewUlid();
    }
    public Ulid InvoiceId { get; private set; }
    public RentInvoice RentInvoice { get; private set; }
    public SaleInvoice SaleInvoice { get; private set; }

    public Ulid BookId { get; private set; }
    public Book Book { get; private set; }

    public int Quantity { get; private set; }
    public decimal Price { get; private set; }

    public static InvoiceDetail Create(Book book,
        int quantity,
        RentInvoice rentInvoice,
        SaleInvoice saleInvoice)

    {
        if (rentInvoice != null && saleInvoice != null)
            throw new Exception("Only one invoice should initial");
        return new InvoiceDetail
        {
            Book = book,
            BookId = book.Id,
            Quantity = quantity,
            InvoiceId = rentInvoice != null ? rentInvoice.Id : saleInvoice.Id,
            RentInvoice = rentInvoice,
            SaleInvoice = saleInvoice,
            Price = quantity * book.Price
        };
    }

}