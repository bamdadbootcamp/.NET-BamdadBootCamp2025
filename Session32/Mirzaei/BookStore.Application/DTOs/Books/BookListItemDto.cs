﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Application.DTOs.Books
{
    public class BookListItemDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }   
        public int? CategoryId { get; set; }
        public string CategoryName { get; set; }   
        public decimal SalePrice { get; set; }
    }
}
