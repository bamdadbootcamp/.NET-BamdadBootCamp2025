using FluentValidation;

namespace Trello.WebApi.Commands.List.Delete
{
    public class DeleteListCommandValidator : AbstractValidator<DeleteListCommand>
    {
        #region [- Ctor -]
        public DeleteListCommandValidator()
        {
            RuleFor(l => l.ListId)
                .NotEmpty()
                .WithMessage("The ListId is required.")
                .NotNull()
                .WithMessage("ListId can not be empty.");
        } 
        #endregion
    }
}
