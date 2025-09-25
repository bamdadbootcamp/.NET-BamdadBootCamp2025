using FluentValidation;
using MediatR;

namespace Trello.WebApi.Commands.List.Update
{
    public class UpdateListCommandValidator : AbstractValidator<UpdateListCommand>
    {
        #region [- Ctor -]
        public UpdateListCommandValidator()
        {
            RuleFor(l => l.ListId)
                .NotEmpty()
                .WithMessage("listId is required.")
                .NotNull()
                .WithMessage("listId can not be empty.");
        } 
        #endregion
    }
}
