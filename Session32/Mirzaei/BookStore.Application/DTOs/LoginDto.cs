

using System.ComponentModel.DataAnnotations;

namespace BookStore.Application.DTOs;

public class LoginDto
{
    [Required, MaxLength(100)]
    public string UserName { get; set; }
    [Required, MinLength(4), MaxLength(100)]
    public string Password { get; set; }
}
