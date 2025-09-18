using MediatR;
using Microsoft.EntityFrameworkCore;
using ThirdParty.Api.Company.Queries.CheckAllowance;

namespace ThirdParty.Api.SMS.Commands.SendSms;

public record SendSmsCommand(string PhoneNumber, string Text, string CompanyKey, string RequestedIp) : IRequest<bool>;

public class SendSmsCommandHandler(ApplicationDbContext context, IMediator mediator)
    : IRequestHandler<SendSmsCommand, bool>
{
    public async Task<bool> Handle(SendSmsCommand request, CancellationToken cancellationToken)
    {
        var isAllowed = await mediator.Send(
            new CheckAllowanceQuery(
                Guid.Parse(request.CompanyKey),
                request.RequestedIp),
            cancellationToken);
        
        if (!isAllowed)
            return false;

        return true;
    }
}