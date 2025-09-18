using MediatR;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ThirdParty.Api.Company.Queries.CheckAllowance;

public record CheckAllowanceQuery(Guid CompanyKey, string IpAddress) : IRequest<bool>;

public class CheckAllowanceQueryHandler(ApplicationDbContext context)  : IRequestHandler<CheckAllowanceQuery, bool>
{
    public async Task<bool> Handle(CheckAllowanceQuery request, CancellationToken cancellationToken)
    {
        return await context.Companies.AnyAsync(a => 
                a.CompanyKey ==  request.CompanyKey &&
                a.IpAddress == request.IpAddress
            , cancellationToken: cancellationToken);
    }
}
