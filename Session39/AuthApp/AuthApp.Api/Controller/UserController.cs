using AuthApp.Api.Commands.User.SignUp;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AuthApp.Api.Controller;

[ApiController]
[Route("api/[controller]")]
public class UserController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> SignUp([FromBody] SignUpCommand command, CancellationToken cancellationToken)
    {
        var result = await mediator.Send(command, cancellationToken);
        return Ok(result);
    }
    
    [HttpPost("Test")]
    public async Task<IActionResult> Test(CancellationToken cancellationToken)
    {
        return Ok();
    }
    
}