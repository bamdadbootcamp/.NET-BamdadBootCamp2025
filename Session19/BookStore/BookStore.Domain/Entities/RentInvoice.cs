using BookStore.Domain.Entities.Core;
using BookStore.Domain.Entities.Enums;
using System.Runtime.InteropServices;

namespace BookStore.Domain.Entities;

public class RentInvoice : BaseEntity
{
    // Reach Model
     
    private RentInvoice()
    {
    }

    public string Number { get; private set; }
    public RentStatus Status { get; private set; }
    public DateTime InvoiceDateTime { get; private set; }
    public List<InvoiceDetail> InvoiceDetails { get; private set; }
    public decimal? FinePrice { get; private set; }
    public decimal TotalPrice { get; private set; }
    public DateTime DeliveryDate { get; private set; }

    public static RentInvoice Create()
    {
       
        return new RentInvoice
        {
            Number = $"R-{100}",
            Status = RentStatus.Rented,
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
    public void CloseInvoice(DateTime deliveryDate)
    {
        if (deliveryDate <= DeliveryDate)
            Status = RentStatus.Returned;
        else
        {
            var delayedDurationDays = (deliveryDate - DeliveryDate).Days;
            decimal finePrice = 0;
            foreach (var detail in InvoiceDetails)
            {
                if (detail.Book.FinePricePerDay.HasValue)
                    finePrice += detail.Book.FinePricePerDay.Value * delayedDurationDays;
            }
            Status = RentStatus.ReturnedWithFine;
            FinePrice = finePrice;
            TotalPrice += finePrice;
        }
    }
}
