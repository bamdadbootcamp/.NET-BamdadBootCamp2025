using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Common.Enums;

namespace BookStore.Application.DTOs
{
    public class CreateCustomerDto
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public Gender Gender { get; set; }
        public DateOnly? BirthDate { get; set; }
        public decimal Credit { get; set; }       
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string TelegramId { get; set; }
        public string WhatsAppNumber { get; set; }
        public string Country { get; set; }
        public State City { get; set; }
        public string PostalCode { get; set; }
        public string FullAddress { get; set; }
        public string Description { get; set; }
        public int CustomerTypeId { get; set; }
    }
}
