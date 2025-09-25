using FluentValidation;

namespace Trello.WebApi.Commands.Board.Create
{
    public class CreateBoardCommandValidator : AbstractValidator<CreateBoardCommand>
    {
        #region [- Ctor -]
        public CreateBoardCommandValidator()
        {
            RuleFor(b => b.Title)
                .NotEmpty()
                .WithMessage("Title is required.")
                .NotNull()
                .WithMessage("Title can not be empty.")
                .MinimumLength(3)
                .WithMessage("The minimum length is 3 characters.")
                .MaximumLength(64)
                .WithMessage("The maximum length is 64 characters."); 
        } 
        #endregion
    }
}
