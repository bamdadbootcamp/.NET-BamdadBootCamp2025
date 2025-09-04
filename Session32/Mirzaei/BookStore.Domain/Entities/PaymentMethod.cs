using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Domain.Core;

namespace BookStore.Domain.Entities
{
    public class PaymentMethod : BaseEntity
    {
        public string Title { get; private set; }
        public ICollection<SaleInvoice> SaleInvoices { get; private set; } = new List<SaleInvoice>();
        public ICollection<RentInvoice> RentInvoices { get; private set; } = new List<RentInvoice>();
    }
}
