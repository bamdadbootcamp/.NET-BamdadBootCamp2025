using MediatR;
using Microsoft.AspNetCore.Mvc;
using ThirdParty.Api.NationalId.Queries.NationalIdValidateWithBirthdate;
using ThirdParty.Api.SMS.Commands.SendSms;

namespace ThirdParty.Api.Controllers;

[Route("api/[controller]")]
public class NationalIdController(IMediator mediator) : ControllerBase
{
    [HttpPost("")]
    public async Task<IActionResult> Get(
        [FromBody] NationalIdValidateWithBirthdateQuery query,
        CancellationToken cancellationToken)
    {
        var response = await mediator.Send(query, cancellationToken);
        return Ok(response);
    }
}