using BookStore.BL.Dto;
using BookStore.Domain.Entities;

namespace BookStore.BL.Services;

public class RentInvoiceService
{
    private List<RentInvoice> _invoices = new List<RentInvoice>();
    public void NewInvoice(List<AddInvoiceDto> invoiceDtos)
    {
        var invoice = RentInvoice.Create();

        foreach (var bookData in invoiceDtos)
        {
            invoice.AddDetail(InvoiceDetail.Create(bookData.Book, bookData.Quantity, invoice, null));
        }
        _invoices.Add(invoice);
    }

    public List<RentInvoice> GetAll() => _invoices;

}
