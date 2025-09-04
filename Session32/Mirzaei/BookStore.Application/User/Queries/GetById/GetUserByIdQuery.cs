using BookStore.Application.User.Queries.Dto;
using MediatR;

namespace BookStore.Application.User.Queries.GetById;

public record GetUserByIdQuery(long Id) : IRequest<UserDto>;
