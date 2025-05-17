using BookStore.Domain.Entities;

namespace BookStore.BL.Dto;

public class AddInvoiceDto
{
    public Book Book { get; set; }
    public int Quantity { get; set; }
}
