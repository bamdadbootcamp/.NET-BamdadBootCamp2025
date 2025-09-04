using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Domain.Core;

namespace BookStore.Domain.Entities
{
    public class Book : BaseEntity
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Publisher { get; private set; }
        public short YearPublished { get; private set; }
        public string Edition { get; private set; }
        public string Isbn { get; private set; }

        public int LanguageId { get; private set; }
        public Language Language { get; private set; }

        public int? CategoryId { get; private set; }
        public Category Category { get; private set; }
        
        public ICollection<InvoiceItem> InvoiceItems { get; set; } = new List<InvoiceItem>();

        public decimal SalePrice { get; private set; }
        public decimal RentPrice { get; private set; }
        public bool IsAvailableForRent { get; private set; }
        public bool IsAvailableForSales { get; private set; }
        public short RentalDurationDays { get; private set; }
        public byte DiscountPercent { get; private set; }
        public int PageCount { get; private set; }
        public string Dimensions { get; private set; }
        public decimal WeightGrams { get; private set; }
        public int Stock { get; private set; }
        public string Description { get; private set; }
        public string CoverImagePath { get; private set; }

        public static Book Create(string title, string author, string publisher, short yearPublished, string edition,
            string isbn, int languageId, int? categoryId, decimal salePrice, decimal rentPrice,
            bool isAvailableForRent, bool isAvailableForSales, short rentalDurationDays, byte discountPercent,
            int pageCount, string dimensions, decimal weightGrams, int stock, string description,
            string coverImagePath)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Book title cannot be empty.", nameof(title));
            if (string.IsNullOrWhiteSpace(author))
                throw new ArgumentException("Book author cannot be empty.", nameof(author));
            if (string.IsNullOrWhiteSpace(isbn))
                throw new ArgumentException("Book ISBN cannot be empty.", nameof(isbn));
            if (salePrice < 0)
                throw new ArgumentOutOfRangeException(nameof(salePrice), "Sale price cannot be negative.");
            if (rentPrice < 0)
                throw new ArgumentOutOfRangeException(nameof(rentPrice), "Rent price cannot be negative.");
            if (discountPercent > 100)
                throw new ArgumentOutOfRangeException(nameof(discountPercent), "Discount percent must be between 0 and 100.");
            if (stock < 0)
                throw new ArgumentOutOfRangeException(nameof(stock), "Stock cannot be negative.");
            return new Book
            {
                Title = title,
                Author = author,
                Publisher = publisher,
                YearPublished = yearPublished,
                Edition = edition,
                Isbn = isbn,
                LanguageId = languageId,
                CategoryId = categoryId,
                SalePrice = salePrice,
                RentPrice = rentPrice,
                IsAvailableForRent = isAvailableForRent,
                IsAvailableForSales = isAvailableForSales,
                RentalDurationDays = rentalDurationDays,
                DiscountPercent = discountPercent,
                PageCount = pageCount,
                Dimensions = dimensions,
                WeightGrams = weightGrams,
                Stock = stock,
                Description = description,
                CoverImagePath = coverImagePath,
                CreateDate = DateTime.Now,
            };
        }
        public static void Update(Book book, string title, string author, string publisher, short yearPublished, string edition,
            string isbn, int languageId, int? categoryId, decimal salePrice, decimal rentPrice,
            bool isAvailableForRent, bool isAvailableForSales, short rentalDurationDays, byte discountPercent,
            int pageCount, string dimensions, decimal weightGrams, int stock, string description,
            string coverImagePath)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Book title cannot be empty.", nameof(title));
            if (string.IsNullOrWhiteSpace(author))
                throw new ArgumentException("Book author cannot be empty.", nameof(author));
            if (string.IsNullOrWhiteSpace(isbn))
                throw new ArgumentException("Book ISBN cannot be empty.", nameof(isbn));
            if (salePrice < 0)
                throw new ArgumentOutOfRangeException(nameof(salePrice), "Sale price cannot be negative.");
            if (rentPrice < 0)
                throw new ArgumentOutOfRangeException(nameof(rentPrice), "Rent price cannot be negative.");
            if (discountPercent > 100)
                throw new ArgumentOutOfRangeException(nameof(discountPercent), "Discount percent must be between 0 and 100.");
            if (stock < 0)
                throw new ArgumentOutOfRangeException(nameof(stock), "Stock cannot be negative.");
            book.Title = title;
            book.Author = author;
            book.Publisher = publisher;
            book.YearPublished = yearPublished;
            book.Edition = edition;
            book.Isbn = isbn;
            book.LanguageId = languageId;
            book.CategoryId = categoryId;
            book.SalePrice = salePrice;
            book.RentPrice = rentPrice;
            book.IsAvailableForRent = isAvailableForRent;
            book.IsAvailableForSales = isAvailableForSales;
            book.RentalDurationDays = rentalDurationDays;
            book.DiscountPercent = discountPercent;
            book.PageCount = pageCount;
            book.Dimensions = dimensions;
            book.WeightGrams = weightGrams;
            book.Stock = stock;
            book.Description = description;
            book.CoverImagePath = coverImagePath;
            book.UpdateDate = DateTime.Now;
        } 
        

        

    }
}
