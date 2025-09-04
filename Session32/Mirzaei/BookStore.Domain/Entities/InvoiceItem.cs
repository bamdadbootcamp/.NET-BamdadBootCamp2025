using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Domain.Core;

namespace BookStore.Domain.Entities
{
    public class InvoiceItem :BaseEntity
    {

        public int BookId { get; private set; }
        public Book Book { get; private set; }

        public int Quantity { get; private set; }
        public decimal UnitPrice { get; private set; }
        public decimal TotalPrice { get; private set; }

        public int? RentInvoiceId { get; private set; }
        public RentInvoice RentInvoice { get; private set; }

        public int? SaleInvoiceId { get; private set; }
        public SaleInvoice SaleInvoice { get; private set; }
    }
}
