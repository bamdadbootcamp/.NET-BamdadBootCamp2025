using CRM.WebApi.Tickets.Dto;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CRM.WebApi.Tickets.Queries.GetPaginated;

public record GetTicketsPaginatedQuery(
    [FromRoute] int PageNumber = 1,
    [FromRoute] int PageSize = 10)
    : IRequest<IEnumerable<GetTicketDto>>;