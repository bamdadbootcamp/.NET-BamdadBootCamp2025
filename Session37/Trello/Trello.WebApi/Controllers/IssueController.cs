using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using Trello.WebApi.Commands.Board.Create;
using Trello.WebApi.Commands.Issue.Create;
using Trello.WebApi.Commands.Issue.Delete;
using Trello.WebApi.Commands.Issue.Update;

namespace Trello.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class IssueController  :ControllerBase
    {
        #region [- Fields -]
        private readonly IMediator _mediator;
        #endregion

        #region [- Ctor -]
        public IssueController(IMediator mediator)
        {
            _mediator = mediator;
        }
        #endregion

        [HttpPost]
        #region [- CreateIssue -]
        public async Task<IActionResult> Create([FromBody, Required] CreateIssueCommand createIssueCommand, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(createIssueCommand, cancellationToken);
            return Ok(result);
        }
        #endregion

        [HttpPut]
        #region [- UpdateIssue -]
        public async Task<IActionResult> Update([FromBody, Required] UpdateIssueCommand updateIssueCommand, CancellationToken cancellationToken)
        {
            await _mediator.Send(updateIssueCommand, cancellationToken);
            return Ok();
        }
        #endregion

        [HttpDelete]
        #region [- DeleteIssue -]
        public async Task<IActionResult> Delete(DeleteIssueCommand deleteIssueCommand, CancellationToken cancellationToken)
        {
            await _mediator.Send(deleteIssueCommand, cancellationToken);
            return Ok();
        }
        #endregion
    }
}
