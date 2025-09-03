using Application.Common.Mediator;

namespace Application.Features.Users.CreateUser;

public record CreateUserCommand(string Name) : IRequest<int>;