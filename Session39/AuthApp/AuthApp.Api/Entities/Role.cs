using Microsoft.AspNetCore.Identity;

namespace AuthApp.Api.Entities;

public class Role : IdentityRole
{
    public bool LockoutEnabled { get; set; } = false;
}