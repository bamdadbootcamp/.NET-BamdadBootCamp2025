using FluentValidation;

namespace Trello.WebApi.Commands.Issue.Delete
{
    public class DeleteIssueCommandValidator : AbstractValidator<DeleteIssueCommand>
    {
        #region [- Ctor -]
        public DeleteIssueCommandValidator()
        {
            RuleFor(i => i.IssueId)
                .NotEmpty()
                .WithMessage("The IssueId is required.")
                .NotNull()
                .WithMessage("IssueId can not be empty.");
        } 
        #endregion
    }
}
