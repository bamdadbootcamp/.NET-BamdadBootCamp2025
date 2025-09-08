using CRM.WebApi.Entities;
using MediatR;

namespace CRM.WebApi.Users.Commands.CreateUser;

public class CreateUserCommandHandler(ApplicationDbContext dbContext) : IRequestHandler<CreateUserCommand>
{
    public async Task Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = User.CreateUser(request.Username, request.Password);
        await dbContext.Users.AddAsync(user, cancellationToken);
        await dbContext.SaveChangesAsync(cancellationToken);
    }
}