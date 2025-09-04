using Application.Common.Mediator;

namespace Application.Features.Users.UpdateUser;

public record UpdateUserCommand(int Id, string Name) : IRequest<int>;