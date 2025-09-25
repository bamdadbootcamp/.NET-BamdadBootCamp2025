using FluentValidation;

namespace Trello.WebApi.Commands.List.Create
{
    public class CreateListCommandValidator : AbstractValidator<CreateListCommand>
    {
        #region [- Ctor -]
        public CreateListCommandValidator()
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

            RuleFor(l => l.BoardId)
                .NotEmpty()
                .WithMessage("Name is required.")
                .NotNull()
                .WithMessage("Name can not be empty."); ;
        } 
        #endregion
    }
}
