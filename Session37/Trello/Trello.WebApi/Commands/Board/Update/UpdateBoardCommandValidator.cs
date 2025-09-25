using FluentValidation;

namespace Trello.WebApi.Commands.Board.Update
{
    public class UpdateBoardCommandValidator : AbstractValidator<UpdateBoardCommand>
    {
        public UpdateBoardCommandValidator()
        {
            RuleFor(b => b.Id)
                .NotEmpty()
                .WithMessage("The IssueId is required!")
                .NotNull()
                .WithMessage("Name can not be empty.");
        } 
    }
}
