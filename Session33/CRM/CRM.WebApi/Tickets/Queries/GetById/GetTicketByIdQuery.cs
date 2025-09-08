using CRM.WebApi.Tickets.Dto;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CRM.WebApi.Tickets.Queries.GetById;

public record GetTicketByIdQuery([FromRoute] Ulid TicketId) : IRequest<GetTicketDto>;