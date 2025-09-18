using MediatR;
using ThirdParty.Api.Company.Queries.CheckAllowance;

namespace ThirdParty.Api.Email.Commands.SendEmail;

public record SendEmailCommand(string Email, string Subject, string Body, string CompanyKey, string RequestedIp) : IRequest<bool>;

public class SendEmailCommandHandler(IMediator mediator) : IRequestHandler<SendEmailCommand, bool>
{
    public async Task<bool> Handle(SendEmailCommand request, CancellationToken cancellationToken)
    {
        var isAllowed = await mediator.Send(
            new CheckAllowanceQuery(
                Guid.Parse(request.CompanyKey),
                request.RequestedIp),
            cancellationToken);
        
        if (!isAllowed)
            return false;
    }

}
