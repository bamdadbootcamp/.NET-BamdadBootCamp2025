using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Trello.WebApi.Commands.List.Create;
using Trello.WebApi.Commands.List.Delete;
using Trello.WebApi.Commands.List.Update;

namespace Trello.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ListController : ControllerBase
    {
        #region [- Fields -]
        private readonly IMediator _mediator;
        #endregion

        #region [- Ctor -]
        public ListController(IMediator mediator)
        {
            _mediator = mediator;
        }
        #endregion

        [HttpPost]
        #region [- CreateList -]
        public async Task<IActionResult> Create([FromBody, Required] CreateListCommand createListCommand, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(createListCommand, cancellationToken);
            return Ok(result);
        }
        #endregion

        [HttpPut]
        #region [- UpdateList -]
        public async Task<IActionResult> Update([FromBody, Required] UpdateListCommand updateListCommand, CancellationToken cancellationToken)
        {
            await _mediator.Send(updateListCommand, cancellationToken);
            return Ok();
        }
        #endregion

        [HttpDelete]
        #region [- DeleteList -]
        public async Task<IActionResult> Delete(DeleteListCommand deleteListCommand, CancellationToken cancellationToken)
        {
            await _mediator.Send(deleteListCommand, cancellationToken);
            return Ok();
        }
        #endregion
    }
}
