using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Trello.WebApi.Commands.Board.Create;
using Trello.WebApi.Commands.Board.Delete;
using Trello.WebApi.Commands.Board.Update;

namespace Trello.WebApi.Controllers;

[Route("api/[controller]")]
public class BoardController : ControllerBase
{
    private readonly IMediator _mediator;

    public BoardController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody, Required] CreateBoardCommand createBoardCommand,
        CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(createBoardCommand, cancellationToken);
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody, Required] UpdateBoardCommand updateBoardCommand,
        CancellationToken cancellationToken)
    {
        await _mediator.Send(updateBoardCommand, cancellationToken);
        return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(DeleteBoardCommand deleteBoardCommand, CancellationToken cancellationToken)
    {
        await _mediator.Send(deleteBoardCommand, cancellationToken);
        return Ok();
    }
}