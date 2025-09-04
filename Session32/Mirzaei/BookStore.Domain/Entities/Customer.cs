using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using BookStore.Domain.Core;
using BookStore.Common.Enums;

namespace BookStore.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string FullName => $"{FirstName} {LastName}";
        public string NationalCode { get; private set; }
        public Gender Gender { get; private set; }
        public DateOnly? BirtDate { get; private set; }
        public bool IsActive { get; private set; }
        public decimal Credit { get; private set; }
        public int LoyalPoints { get; private set; }

        public int CustomerTypeId { get; private set; }
        public CustomerType CustomerType { get; private set; }


        public ICollection<Address> Addresses { get; private set; } = new List<Address>();

        public ContactInfo ContactInfo { get; private set; }

        public ICollection<SaleInvoice> SaleInvoices { get; private set; } = new List<SaleInvoice>();

        public ICollection<RentInvoice> RentInvoices { get; private set; } = new List<RentInvoice>();

        public static Customer Create(string firstName, string lastName, string nationalCode, Gender gender, DateOnly birthDate, string country, State city, string postalCode, string fullAdress, string description, string phoneNumber, string mobileNumber, string email, string telegramId, string watsappNumber, int customerTypeId)
        {
            var customer = new Customer
            {
                FirstName = firstName,
                LastName = lastName,
                NationalCode = nationalCode,
                Gender = gender,
                BirtDate = birthDate,
                Addresses = (ICollection<Address>)Address.Create(country, city, postalCode, fullAdress, description),
                ContactInfo = ContactInfo.Create(phoneNumber, mobileNumber, email, telegramId, watsappNumber),
                CustomerTypeId = customerTypeId,
                Credit = 0,
                LoyalPoints = 0,
                IsActive = true,
                CreateDate = DateTime.Now
            };
            return customer;
        }
    }
}
