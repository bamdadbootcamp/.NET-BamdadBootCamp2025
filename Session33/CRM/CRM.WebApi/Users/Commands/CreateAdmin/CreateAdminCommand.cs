using MediatR;

namespace CRM.WebApi.Users.Commands.CreateAdmin;

public record CreateAdminCommand(
    string Username,
    string Password,
    string ConfirmPassword) : IRequest;