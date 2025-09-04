using BookStore.Application.DTOs;
using BookStore.DAL.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public AuthController(ApplicationDbContext db) => _db = db;
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto dto)
        {
            var user = await _db.Users.SingleOrDefaultAsync(u => u.UserName == dto.UserName && u.Password == dto.Password);

            if (user is null) return Unauthorized();
            return Ok(new { message = "Login ok" });
        }
    }
}
