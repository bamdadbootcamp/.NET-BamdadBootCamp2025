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
    public IActionResult SignUp(CreateUserDto dto)
    {
        userManagementService.SignUp(dto);
        return Ok();
    }

    [HttpPost(nameof(ChangePassword))]
    public IActionResult ChangePassword()
    {
        return Ok();
    }

    [HttpGet(nameof(Get))]
    public IActionResult Get()
    {
        var users = userManagementService.GetUsers();
        return Ok(users);
    }

    [HttpGet(nameof(GetById))]
    public IActionResult GetById()
    {
        return Ok();
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
