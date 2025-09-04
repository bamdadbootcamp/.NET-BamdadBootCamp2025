using BookStore.Application.User.Queries.Dto;
using BookStore.DAL.Contract;
using MediatR;
using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;

namespace BookStore.Application.User.Queries.GetById;

public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, UserDto>
{
    private readonly IUserRepository _repository;

    public GetUserByIdQueryHandler(IUserRepository repository)
    {
        _repository = repository;
    }

    public async Task<UserDto> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
        var user = await _repository.GetByIdAsync(request.Id, cancellationToken);
        return new UserDto()
        {
            UserName = user.UserName
        };
    }
}