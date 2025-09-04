using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Application.DTOs.Books;

public class CreatBookDto
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public short YearPublished { get; set; }
    public string Edition { get; set; }
    public string Isbn { get; set; }
    public int LanguageId { get; set; }
    public int? CategoryId { get; set; }
    public decimal SalePrice { get; set; }
    public decimal RentPrice { get; set; }
    public bool IsAvailableForRent { get; set; }
    public bool IsAvailableForSales { get; set; }
    public short RentalDurationDays { get; set; }
    public byte DiscountPercent { get; set; }
    public int PageCount { get; set; }
    public string Dimensions { get; set; }
    public decimal WeightGrams { get; set; }
    public int Stock { get; set; }
    public string? Description { get; set; }
    public string CoverImagePath { get; set; }
}