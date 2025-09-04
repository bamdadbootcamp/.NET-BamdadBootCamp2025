using BookStore.Application.DTOs.Languages;
using BookStore.DAL.Contexts;
using BookStore.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public LanguagesController(ApplicationDbContext db) => _db = db;
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LanguageListItemDto>>> GetAll([FromQuery] string? search = null)
        {
            var q = _db.Languages.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search))
                q = q.Where(c => c.Name.Contains(search));
            var list = await q.OrderBy(c => c.Name)
                .Select(c => new LanguageListItemDto
                {
                    Id = c.Id,
                    Name = c.Name,
                })
                .ToListAsync();
            return Ok(list);
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<LanguageListItemDto>> GetById(int id)
        {
            var item = await _db.Languages
                .Where(c => c.Id == id)
                .Select(c => new LanguageListItemDto
                {
                    Id = c.Id,
                    Name = c.Name,
                })
                .SingleOrDefaultAsync();
            return item is null ? NotFound() : Ok(item);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateLanguageDto dto)
        {
            var exists = await _db.Languages.AnyAsync(c => c.Name == dto.Name);
            if (exists) return Conflict("Language name already exists.");
            var lang = Language.Create(dto.Name);
            _db.Languages.Add(lang);
            await _db.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = lang.Id }, new { lang.Id, lang.Name });

        }
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateLanguageDto dto)
        {
            var lang = await _db.Languages.FindAsync(id);
            if (lang is null) return NotFound();
            var name = dto.Name.Trim();
            var exists = await _db.Languages.AnyAsync(c => c.Name == name && c.Id != id);
            if (exists) return Conflict("Language name already exists.");
            Language.Update(lang, name);
            await _db.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var lang = await _db.Languages.FindAsync(id);
            if (lang is null) return NotFound();
            _db.Languages.Remove(lang);
            try
            {
                await _db.SaveChangesAsync();
                return NoContent();
            }
            catch (DbUpdateException)
            {
                return Conflict("You cannot delete this language because it is referenced by some books.");
            }
        }
    }
}
