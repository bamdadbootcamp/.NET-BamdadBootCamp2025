using MediatR;
using Microsoft.AspNetCore.Mvc;
using ThirdParty.Api.Email.Commands.SendEmail;
using ThirdParty.Api.SMS.Commands.SendSms;

namespace ThirdParty.Api.Controllers;

[Route("api/[controller]")]
public class EmailController(IMediator mediator) : ControllerBase
{

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] SendEmailCommand command, CancellationToken cancellationToken)
    {
        var response = await mediator.Send(command, cancellationToken);
        return Ok(response);
    }
}