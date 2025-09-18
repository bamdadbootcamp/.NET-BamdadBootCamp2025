using System.Text.RegularExpressions;
using FluentValidation;

namespace ThirdParty.Api.SMS.Commands.SendSms;

public class SendSmsCommandValidator : AbstractValidator<SendSmsCommand>
{
    public SendSmsCommandValidator()
    {
        RuleFor(r => r.PhoneNumber)
            .NotNull()
            .WithMessage("PhoneNumber cannot be empty.")
            .NotEmpty()
            .WithMessage("PhoneNumber is required.")
            .Length(11)
            .WithMessage("PhoneNumber must contain 11 digits.")
            .Matches(@"^(0912|0919|0910|0935|0936|0937|0938|0939|0930|0991)\d{7}$")
            .WithMessage("PhoneNumber must be 11 digits and start with a valid prefix.");
            
            
        
        RuleFor(r => r.Text)
            .NotNull()
            .WithMessage("Text cannot be empty.")
            .NotEmpty()
            .WithMessage("Text is required.")
            .MaximumLength(500)
            .WithMessage("Text cannot exceed 500 characters.");
       
    }
}