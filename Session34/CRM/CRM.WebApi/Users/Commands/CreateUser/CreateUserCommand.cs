using MediatR;

namespace CRM.WebApi.Users.Commands.CreateUser;

public record CreateUserCommand(
    string Username,
    string Password,
    string ConfirmPassword) : IRequest;