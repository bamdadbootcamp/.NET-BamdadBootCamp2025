using MediatR;
using ThirdParty.Api.SMS.Commands.SendSms;

namespace ThirdParty.Api.NationalId.Queries.NationalIdValidateWithBirthdate;

public record NationalIdValidateWithBirthdateQuery(string NationalId, string Birthdate, string CompanyKey, string RequestedIp) : IRequest<bool>;

public class NationalIdValidateWithBirthdateQueryHandler : IRequestHandler<NationalIdValidateWithBirthdateQuery, bool>
{
    public async Task<bool> Handle(NationalIdValidateWithBirthdateQuery request, CancellationToken cancellationToken)
    {
        return true;
    }

}
