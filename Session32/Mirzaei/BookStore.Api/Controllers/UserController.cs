using BookStore.Application.Commands.User.Create;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Api.Controllers;

[Route("api/[controller]")]
public class UserController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Post(CreateUserCommand command, CancellationToken cancellationToken)
    {
        var result = await mediator.Send(command, cancellationToken);
        return Ok(result);
    }
}