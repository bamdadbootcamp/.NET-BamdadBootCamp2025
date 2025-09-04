using BookStore.BL.Dto;
using BookStore.Domain.Entities;

namespace BookStore.BL.Services;

public static class SaleInvoiceService
{
    private static List<SaleInvoice> _invoices = new List<SaleInvoice>();
    public static void NewInvoice(List<AddInvoiceDto> invoiceDtos)
    {
        var invoice = SaleInvoice.Create();

        foreach (var bookData in invoiceDtos)
        {
            invoice.AddDetail(InvoiceDetail.Create(bookData.Book, bookData.Quantity, null, invoice));
        }
        _invoices.Add(invoice);
    }

    public static List<SaleInvoice> GetAll() => _invoices;

    public static void Update(SaleInvoice invoice)
    {

    }

}
