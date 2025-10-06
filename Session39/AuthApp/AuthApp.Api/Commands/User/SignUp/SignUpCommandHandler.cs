using MediatR;
using Microsoft.AspNetCore.Identity;

namespace AuthApp.Api.Commands.User.SignUp;

public class SignUpCommandHandler(UserManager<Entities.User> userManager) : IRequestHandler<SignUpCommand, Unit>
{
    public async Task<Unit> Handle(SignUpCommand request, CancellationToken cancellationToken)
    {
        if (!string.Equals(request.Password, request.ConfirmPassword, StringComparison.InvariantCulture))
            throw new Exception("Passwords do not match.");
        
        Entities.User user = new Entities.User();
        user.UserName = request.Email;
        user.Email = request.Email;

        var result = await userManager.CreateAsync(user, request.Password);

        if (result.Succeeded)
        {
            return Unit.Value;
        }
        throw new Exception("Failed to create user.");
    }
}