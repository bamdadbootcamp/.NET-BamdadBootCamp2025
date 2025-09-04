using FluentValidation;

namespace BookStore.Application.Commands.User.Create;

public class CreateUserCommandValidator :  AbstractValidator<CreateUserCommand>
{
    public CreateUserCommandValidator()
    {
        RuleFor(r => r.UserName)
            .NotEmpty()
            .WithMessage("Username is required")
            .NotNull()
            .WithMessage("Username cannot be empty")
            .MinimumLength(3)
            .WithMessage("Username must be at least 3 characters")
            .MaximumLength(100)
            .WithMessage("Username cannot exceed 100 characters");
        
        RuleFor(r =>r.Password)
            .NotEmpty()
            .WithMessage("Password is required")
            .NotNull()
            .WithMessage("Password cannot be empty")
            .MinimumLength(3)
            .WithMessage("Password must be at least 3 characters")
            .MaximumLength(100)
            .WithMessage("Password cannot exceed 100 characters");

    }
}