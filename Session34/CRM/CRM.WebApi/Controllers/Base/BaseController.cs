using CRM.WebApi.Users.Commands.CreateUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CRM.WebApi.Controllers.Base;

[Route("api/[controller]")]
public abstract class BaseController<T>(IMediator mediator) : ControllerBase
    where T : IRequest<T>
{
    // protected readonly IMediator _mediator = mediator;
    //
    // // RESTful 
    //
    // [HttpGet]
    // public async Task<IActionResult> Get(T request, CancellationToken cancellationToken = default)
    // {
    //     var result = await _mediator.Send(request, cancellationToken);
    //     return Ok(result);
    // }
}