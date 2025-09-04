using MediatR;

namespace BookStore.Application.Commands.User.Create;

// public class CreateUserCommand : IRequest<long>
// {
//     public required string UserName { get; set; }
//     public required string Password { get; set; }
// }

public record CreateUserCommand(string UserName, string Password) : IRequest<long>;