using BookStore.BL.Dto;
using BookStore.Domain.Entities;

namespace BookStore.BL.Services;

public static class RentInvoiceService
{
    private static List<RentInvoice> _invoices = new List<RentInvoice>();

    // CREATE
    public static void NewInvoice(List<AddInvoiceDto> invoiceDtos)
    {
        var invoice = RentInvoice.Create();

        foreach (var bookData in invoiceDtos)
        {
            invoice.AddDetail(InvoiceDetail.Create(bookData.Book, bookData.Quantity, invoice, null));
        }
        _invoices.Add(invoice);
    }

    // READ
    public static List<RentInvoice> GetAll() => _invoices;

    // EDIT

    // DELETE

}
