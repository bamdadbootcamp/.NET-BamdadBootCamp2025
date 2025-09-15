// using CRM.WebApi.Users.Commands.CreateAdmin;
// using CRM.WebApi.Users.Commands.CreateUser;
// using MediatR;
// using Microsoft.AspNetCore.Mvc;
//
// namespace CRM.WebApi.Controllers;
//
// [Route("api/[controller]")]
// public class UserController(IMediator mediator) : ControllerBase
// {
//     [HttpPost("create-user")]
//     public async Task<IActionResult> PostUser(CreateUserCommand command, CancellationToken cancellationToken)
//     {
//         await mediator.Send(command, cancellationToken);
//         return Ok();
//     }
//     
//     [HttpPost("create-admin")]
//     public async Task<IActionResult> PostAdmin(CreateAdminCommand command, CancellationToken cancellationToken)
//     {
//         await mediator.Send(command, cancellationToken);
//         return Ok();
//     }
// }