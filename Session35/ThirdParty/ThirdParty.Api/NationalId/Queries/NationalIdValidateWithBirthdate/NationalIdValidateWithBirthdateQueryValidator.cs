using FluentValidation;
using ThirdParty.Api.SMS.Commands.SendSms;

namespace ThirdParty.Api.NationalId.Queries.NationalIdValidateWithBirthdate;

public class NationalIdValidateWithBirthdateQueryValidator : AbstractValidator<NationalIdValidateWithBirthdateQuery>
{
    public NationalIdValidateWithBirthdateQueryValidator()
    {
        RuleFor(r => r.NationalId)
            .NotNull()
            .WithMessage("NationalId cannot be empty.")
            .NotEmpty()
            .WithMessage("NationalId is required.")
            .Length(10)
            .WithMessage("NationalId must contain 10 characters.");

        RuleFor(r => r.Birthdate)
            .NotNull()
            .WithMessage("Birthdate cannot be empty.")
            .NotEmpty()
            .WithMessage("Birthdate is required.")
            .Length(8)
            .WithMessage("Birthdate must contain 8 characters.");
    }
}