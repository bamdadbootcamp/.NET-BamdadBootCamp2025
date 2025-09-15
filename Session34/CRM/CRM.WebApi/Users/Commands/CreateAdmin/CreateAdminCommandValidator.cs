using CRM.WebApi.Consts;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace CRM.WebApi.Users.Commands.CreateAdmin;

public class CreateAdminCommandValidator :  AbstractValidator<CreateAdminCommand>
{
    private readonly ApplicationDbContext _context;

    public CreateAdminCommandValidator(ApplicationDbContext context)
    {
        _context = context;
        RuleFor(x => x.Username)
            .NotEmpty()
            .WithMessage("Username is required")
            .MustAsync(BeUniqueUsername)
            .WithMessage("Username already exists")
            .MaximumLength(EntityConsts.USER_USERNAME.MaxLength)
            .WithMessage("Username must not exceed 100 characters")
            .MinimumLength(EntityConsts.USER_USERNAME.MinLength)
            .WithMessage("Username must not exceed 3 characters");
        
        RuleFor(x => x.Password)
            .NotEmpty()
            .WithMessage("Password is required");
        
        RuleFor(x => x.ConfirmPassword)
            .Equal(x => x.Password)
            .WithMessage("Passwords do not match");
    }

    private async Task<bool> BeUniqueUsername(string username, CancellationToken cancellationToken)
    {
        if (string.IsNullOrWhiteSpace(username)) return true;
        var normalized = username.Normalize();
        return !await _context.Users.AsNoTracking()
            .AnyAsync(u => u.Username == normalized, cancellationToken);
    }
}