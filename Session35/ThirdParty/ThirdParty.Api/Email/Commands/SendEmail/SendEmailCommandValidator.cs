using System.Data;
using FluentValidation;

namespace ThirdParty.Api.Email.Commands.SendEmail;

public class SendEmailCommandValidator : AbstractValidator<SendEmailCommand>
{
    public SendEmailCommandValidator()
    {
        RuleFor(r => r.Email)
            .NotNull()
            .WithMessage("Email cannot be empty.")
            .NotEmpty()
            .WithMessage("Email is required.")
            .EmailAddress()
            .WithMessage("Email is not valid.");
        
        RuleFor(r => r.Subject)
            .NotNull()
            .WithMessage("Subject cannot be empty.")
            .NotEmpty()
            .WithMessage("Subject is required.")
            .MaximumLength(100)
            .WithMessage("Subject cannot exceed 100 characters.");
        
        RuleFor(r => r.Body)
            .NotNull()
            .WithMessage("Body cannot be empty.")
            .NotEmpty()
            .WithMessage("Body is required.")
            .MaximumLength(2048)
            .WithMessage("Body cannot exceed 2048 characters.");
    }
}