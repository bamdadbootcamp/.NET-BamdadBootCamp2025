using Microsoft.AspNetCore.Mvc;
using UserManagement.Application.DTOs;
using UserManagement.Application.Service.Contract;

namespace UserManagement.WebApi.Controllers;

[Route("/api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserManagementService userManagementService;
    public UserController(IUserManagementService userManagementService)
    {
        this.userManagementService = userManagementService;
    }

    [HttpPost(nameof(Login))]
    public IActionResult Login()
    {
        return Ok();
    }

    [HttpPost(nameof(SignUp))]
    public async Task<IActionResult> SignUp(CreateUserDto dto, CancellationToken cancellationToken)
    {
        await userManagementService.SignUpAsync(dto, cancellationToken);
        return Ok();
    }

    [HttpPost(nameof(ChangePassword))]
    public IActionResult ChangePassword()
    {
        return Ok();
    }

    [HttpGet(nameof(Get))]
    public async Task<IActionResult> Get(CancellationToken cancellationToken)
    {
        var users = await userManagementService.GetUsersAsync(cancellationToken);
        return Ok(users);
    }

    [HttpGet(nameof(GetById))]
    public async Task<IActionResult> GetById([FromQuery] long id, CancellationToken cancellationToken)
    {
        var response = await userManagementService.GetByIdAsync(id, cancellationToken);
        return Ok(response);
    }

    [HttpPatch(nameof(Active))]
    public IActionResult Active()
    {
        return Ok();
    }

    [HttpPatch(nameof(Inactive))]
    public IActionResult Inactive()
    {
        return Ok();
    }

    [HttpPut(nameof(Update))]
    public IActionResult Update()
    {
        return Ok();
    }
}
