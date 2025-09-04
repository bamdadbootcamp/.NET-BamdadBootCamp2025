using BookStore.DAL.Contract;
using MediatR;

namespace BookStore.Application.Commands.User.Create;

public class CreateUserCommandHandler(IUserRepository userRepository) : IRequestHandler<CreateUserCommand, long>
{
    public async Task<long> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        Domain.Entities.User user = new()
        {
            UserName = request.UserName,
            Password = request.Password
        };
        await userRepository.AddAsync(user, cancellationToken);
        await userRepository.SaveChangesAsync(cancellationToken);
        return user.Id;
    }
}