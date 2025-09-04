using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Domain.Entities;

namespace BookStore.Application.DTOs
{
    public class CreateContactInfoDto
    {
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string TelegramId { get; set; }
        public string WhatsAppNumber { get; set; }
        public int CustomerId { get; set; }
        
    }
}
