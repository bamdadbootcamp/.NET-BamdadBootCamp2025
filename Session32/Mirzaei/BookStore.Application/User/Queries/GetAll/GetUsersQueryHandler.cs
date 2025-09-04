using BookStore.Application.User.Queries.Dto;
using BookStore.DAL.Contract;
using MediatR;

namespace BookStore.Application.User.Queries.GetAll;

public class GetUsersQueryHandler : IRequestHandler<GetUsersQuery, IEnumerable<UserDto>>
{
    private readonly IUserRepository _repository;

    public GetUsersQueryHandler(IUserRepository repository)
    {
        _repository = repository;
    }
    public async Task<IEnumerable<UserDto>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
    {
        //var query = await _repository.GetAllAsync();
        //query.Skip().Take()
        return null;
    }
}