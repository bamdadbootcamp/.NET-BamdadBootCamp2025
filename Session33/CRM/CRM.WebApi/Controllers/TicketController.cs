using CRM.WebApi.Tickets.Commands.AddChat;
using CRM.WebApi.Tickets.Commands.CloseTicket;
using CRM.WebApi.Tickets.Commands.Create;
using CRM.WebApi.Tickets.Queries.GetById;
using CRM.WebApi.Tickets.Queries.GetPaginated;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CRM.WebApi.Controllers;

[Route("api/[controller]")]
public class TicketController(IMediator mediator) : ControllerBase
{
    [HttpPost("create")]
    public async Task<IActionResult> Post(CreateTicketCommand command, CancellationToken cancellationToken)
    {
        await mediator.Send(command, cancellationToken);
        return Ok();
    }
    
    [HttpPost("chat")]
    public async Task<IActionResult> AddChat(AddChatCommand command, CancellationToken cancellationToken)
    {
        await mediator.Send(command, cancellationToken);
        return Ok();
    }
    
    [HttpPatch("close")]
    public async Task<IActionResult> Close(CloseTicketCommand command, CancellationToken cancellationToken)
    {
        await mediator.Send(command, cancellationToken);
        return Ok();
    }
    
    [HttpGet("get-by-id/{TicketId}")]
    public async Task<IActionResult> GetById(GetTicketByIdQuery command, CancellationToken cancellationToken)
    {
        var result = await mediator.Send(command, cancellationToken);
        return Ok(result);
    }
    
    [HttpGet("get-paginated")]
    public async Task<IActionResult> GetPaginated(GetTicketsPaginatedQuery command, CancellationToken cancellationToken)
    {
        var result = await mediator.Send(command, cancellationToken);
        return Ok(result);
    }
    
}