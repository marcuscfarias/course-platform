using Application.Common.Mediator;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Features.Users.CreateUser;

public class CreateUserCommandHandler(IUserRepository userRepository) : IRequestHandler<CreateUserCommand, int>
{
    public async Task<int> HandleAsync(CreateUserCommand request, CancellationToken cancellationToken = default)
    {
        var user = request.ToDomain();

        var id = await userRepository.AddAsync(user);

        return id;
    }
}