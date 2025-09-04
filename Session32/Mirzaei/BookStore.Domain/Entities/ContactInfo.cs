using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Domain.Core;

namespace BookStore.Domain.Entities
{
    public class ContactInfo :BaseEntity
    {
        public string PhoneNumber { get; private set; }
        public string MobileNumber { get; private set; }
        public string Email { get; private set; }
        public string TelegramId { get; private set; }
        public string WhatsAppNumber { get; private set; }

        public int CustomerId { get; private set; }
        public Customer Customer { get; private set; }

        public static ContactInfo  Create(string phoneNumber, string mobileNumber, string email, string telegramId, string watsappNumber)
        {
            var contactinfo = new ContactInfo
            {
                PhoneNumber = phoneNumber,
                MobileNumber = mobileNumber,
                Email = email,
                TelegramId = telegramId,
                WhatsAppNumber = watsappNumber
            };
            return contactinfo;               
        }
    }
}
