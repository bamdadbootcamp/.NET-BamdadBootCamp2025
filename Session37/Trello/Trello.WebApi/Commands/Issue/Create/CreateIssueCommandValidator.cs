using FluentValidation;

namespace Trello.WebApi.Commands.Issue.Create
{
    public class CreateIssueCommandValidator : AbstractValidator<CreateIssueCommand>
    {
        #region [- Ctor -]
        public CreateIssueCommandValidator()
        {
            RuleFor(i => i.Title)
                .NotEmpty()
                .WithMessage("Name is required.")
                .NotNull()
                .WithMessage("Name can not be empty.")
                .MinimumLength(3)
                .WithMessage("The minimum length is 3 characters.")
                .MaximumLength(64)
                .WithMessage("The maximum length is 64 characters."); 

            RuleFor(i => i.Description)
                .NotEmpty()
                .WithMessage("Name is required.")
                .NotNull()
                .WithMessage("Name can not be empty.")
                .MinimumLength(3)
                .WithMessage("The minimum length is 3 characters.")
                .MaximumLength(64)
                .WithMessage("The maximum length is 64 characters.");

            RuleFor(i => i.ListId)
                .NotEmpty()
                .WithMessage("Name is required.")
                .NotNull()
                .WithMessage("Name can not be empty.");

        } 
        #endregion
    }
}
