using FluentValidation;

namespace Trello.WebApi.Commands.Board.Delete;

public class DeleteBoardCommandValidator : AbstractValidator<DeleteBoardCommand>
{
    public DeleteBoardCommandValidator()
    {
        RuleFor(b => b.Id)
            .NotNull()
            .WithMessage("Name can not be empty.")
            .NotEmpty()
            .WithMessage("Name is required.")
            .GreaterThanOrEqualTo(1)
            .WithMessage("Name must be greater than or equal to 1.");
    }
}