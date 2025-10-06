using Microsoft.AspNetCore.Identity;

namespace AuthApp.Api.Entities;

// Asp.Net Identity
public class User : IdentityUser
{
    public DateTimeOffset PasswordExpireDate { get; set; } = DateTimeOffset.UtcNow.AddDays(30);

    public void RenewPasswordExpireDate()
    {
        PasswordExpireDate = DateTimeOffset.UtcNow.AddDays(30);
    }
}