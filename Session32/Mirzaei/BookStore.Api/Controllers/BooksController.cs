using BookStore.Application.DTOs.Books;
using BookStore.DAL.Contexts;
using BookStore.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public BooksController(ApplicationDbContext db) => _db = db;
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreatBookDto dto)
        {
            
            var name = dto.Title.Trim();
            var exists = await _db.Books.AnyAsync(b => b.Title == name && b.Author == dto.Author);
            if (exists) { return Conflict("Book with the same title and author already exists."); }
            var book = Book.Create(dto.Title, dto.Author, dto.Publisher, dto.YearPublished, dto.Edition,
                dto.Isbn, dto.LanguageId, dto.CategoryId, dto.SalePrice, dto.RentPrice,
                dto.IsAvailableForRent, dto.IsAvailableForSales, dto.RentalDurationDays, dto.DiscountPercent,
                dto.PageCount, dto.Dimensions, dto.WeightGrams, dto.Stock, dto.Description,
                dto.CoverImagePath);
            _db.Books.Add(book);
            await _db.SaveChangesAsync();
            return book != null ? Ok(book) : BadRequest("Book could not be created.");

        }



    }
}
