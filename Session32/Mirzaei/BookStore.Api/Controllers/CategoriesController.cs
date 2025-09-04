using BookStore.DAL.Contexts;
using BookStore.Domain.Entities;
using BookStore.Application.DTOs.Categories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public CategoriesController(ApplicationDbContext db) => _db = db;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryListItemDto>>> GetAll([FromQuery] string? search = null)
        {
            var q = _db.Categories.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search))
                q = q.Where(c => c.Name.Contains(search));

            var list = await q.OrderBy(c => c.Name)
                .Select(c => new CategoryListItemDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    BooksCount = c.Books.Count()
                })
                .ToListAsync();

            return Ok(list);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<CategoryListItemDto>> GetById(int id)
        {
            var item = await _db.Categories
                .Where(c => c.Id == id)
                .Select(c => new CategoryListItemDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    BooksCount = c.Books.Count()
                })
                .SingleOrDefaultAsync();

            return item is null ? NotFound() : Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCategoryDto dto)   
        {
            var name = dto.Name.Trim();
            var exists = await _db.Categories.AnyAsync(c => c.Name == name);
            if (exists) return Conflict("Category name already exists.");

            var cat = Category.Create(name);
            _db.Categories.Add(cat);
            await _db.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = cat.Id }, new { cat.Id, cat.Name });
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateCategoryDto dto)
        {
            var cat = await _db.Categories.FindAsync(id);
            if (cat is null) return NotFound();

            var name = dto.Name.Trim();
            var dup = await _db.Categories.AnyAsync(c => c.Id != id && c.Name == name);
            if (dup) return Conflict("Category name already exists.");
            Category.Update(cat, name);
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var cat = await _db.Categories.FindAsync(id);
            if (cat is null) return NotFound();

            _db.Categories.Remove(cat);
            try
            {
                await _db.SaveChangesAsync();
                return NoContent();
            }
            catch (DbUpdateException)
            {
                return Conflict("Cannot delete: category is in use.");
            }
        }
    }
}
