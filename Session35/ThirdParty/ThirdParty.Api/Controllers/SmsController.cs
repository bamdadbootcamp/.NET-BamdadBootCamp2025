using MediatR;
using Microsoft.AspNetCore.Mvc;
using ThirdParty.Api.SMS.Commands.SendSms;

namespace ThirdParty.Api.Controllers;

[Route("api/[controller]")]
public class SmsController(IMediator mediator) : ControllerBase
{

    public async Task<IActionResult> Post([FromBody] SendSmsCommand command, CancellationToken cancellationToken)
    {
        var response = await mediator.Send(command, cancellationToken);
        return Ok(response);
    }
}