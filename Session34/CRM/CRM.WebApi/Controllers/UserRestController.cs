using CRM.WebApi.Users.Commands.CreateAdmin;
using CRM.WebApi.Users.Commands.CreateUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CRM.WebApi.Controllers;

[Route("api/[controller]")]
public class UserController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var requestedIp = HttpContext.Connection.RemoteIpAddress;
        return Ok();
    }

    [HttpGet("{id}")]
    public IActionResult Get([FromRoute] long id)
    {
        return Ok();
    }

    [HttpPost]
    public IActionResult Post()
    {
        return Ok();
    }

    [HttpPut]
    public IActionResult Put()
    {
        return Ok();
    }
    
    [HttpDelete("{id}")]
    public IActionResult Put(long id)
    {
        return Ok();
    }
}