using MediatR;

namespace AuthApp.Api.Commands.User.SignUp;

public class SignUpCommand : IRequest<Unit>
{
    public required string Email { get; set; }
    public required string Password { get; set; }
    public required string ConfirmPassword { get; set; }
}