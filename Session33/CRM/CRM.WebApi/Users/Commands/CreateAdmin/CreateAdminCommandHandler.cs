using CRM.WebApi.Entities;
using CRM.WebApi.Users.Commands.CreateUser;
using MediatR;

namespace CRM.WebApi.Users.Commands.CreateAdmin;

public class CreateAdminCommandHandler(ApplicationDbContext dbContext) : IRequestHandler<CreateAdminCommand>
{
    public async Task Handle(CreateAdminCommand request, CancellationToken cancellationToken)
    {
        var user = User.CreateAdmin(request.Username, request.Password);
        await dbContext.Users.AddAsync(user, cancellationToken);
        await dbContext.SaveChangesAsync(cancellationToken);
    }
}