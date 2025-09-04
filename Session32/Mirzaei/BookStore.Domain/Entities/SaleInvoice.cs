using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Domain.Core;

namespace BookStore.Domain.Entities
{
    public class SaleInvoice : BaseEntity
    {
        private int CounterToday { get; set; }
        public string SaleInvoiceNumber { get; private set; }

        public int CustomerId { get; private set; }
        public Customer Customer { get; private set; }

        public DateTime InvoiceDate { get; private set; } = DateTime.Now;

        public ICollection<InvoiceItem> InvoiceItems { get; private set; } = new List<InvoiceItem>();

        public decimal TotalAmount { get; private set; }
        public decimal DiscountAmount { get; private set; }
        public bool IsPaid { get; private set; }

        public int PaymentMethodId { get; private set; }
        public PaymentMethod PaymentMethod { get; private set; }

        public byte DiscountPercentage { get; private set; }
        public byte TaxPercentage { get; private set; }
        public string SellerName { get; private set; }
        public string Description { get; private set; }

        public SaleInvoice()
        {
            SaleInvoiceNumber = GenerateInvoiceNumber();
        }
        private string GenerateInvoiceNumber()
        {
            CounterToday += 1;
            string date = GetTodayPersianDate();
            return $"{date}-{CounterToday:D4}-ف";
        }
        private string GetTodayPersianDate()
        {
            var pc = new PersianCalendar();
            var now = DateTime.Now;
            return $"{pc.GetYear(now):0000}{pc.GetMonth(now):00}{pc.GetDayOfMonth(now):00}";
        }
    }
}
