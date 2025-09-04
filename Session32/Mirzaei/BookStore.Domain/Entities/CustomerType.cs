using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Domain.Core;

namespace BookStore.Domain.Entities
{
    public class CustomerType : BaseEntity
    {
        public string Title { get; private set; }
                
        public ICollection<Customer> Customers { get; set; } = new List<Customer>();
    }
}
