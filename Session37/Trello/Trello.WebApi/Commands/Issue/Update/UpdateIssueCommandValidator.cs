using FluentValidation;

namespace Trello.WebApi.Commands.Issue.Update
{
    public class UpdateIssueCommandValidator : AbstractValidator<UpdateIssueCommand>
    {
        #region [- Ctor -]
        public UpdateIssueCommandValidator()
        {
            RuleFor(i => i.IssueId)
                .NotEmpty()
                .WithMessage("IssueId is required.")
                .NotNull()
                .WithMessage("issueId can not be empty.");
        } 
        #endregion
    }
}
