using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Domain.Core;
using BookStore.Common.Enums;


namespace BookStore.Domain.Entities
{
    public class Address : BaseEntity
    {
        public string Country { get; private set; }
        public State City { get; private set; }
        public string PostalCode { get; private set; }
        public string FullAddress { get; private set; }
        public string Description { get; private set; }

        public int CustomerId { get; private set; }             
        public Customer Customer { get; private set; }        

        public static Address Create(string country, State city, string postalCode, string fullAddress, string description)
        {
            var address = new Address
            {
                Country = country,
                City = city,
                PostalCode = postalCode,
                FullAddress = fullAddress,
                Description = description,
                CreateDate = DateTime.Now
            };
            return address;
        }
    }
}
