using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Common.Enums;

namespace BookStore.Application.DTOs
{
    public class CreateAddressDto
    {
        public string Country { get; set; }
        public State City { get; set; }
        public string PostalCode { get; set; }
        public string FullAddress { get; set; }
        public string Description { get; set; }
    }
}
