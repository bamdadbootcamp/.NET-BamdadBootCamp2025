using BookStore.Application.User.Queries.Dto;
using MediatR;

namespace BookStore.Application.User.Queries.GetAll;

public class GetUsersQuery : IRequest<IEnumerable<UserDto>>
{
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 10;
}