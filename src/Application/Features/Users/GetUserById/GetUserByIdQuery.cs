using Application.Common.Mediator;
using Domain.Entities;

namespace Application.Features.Users.GetUserById;

public record GetUserByIdQuery(int Id) : IRequest<GetUserByIdViewModel?>;