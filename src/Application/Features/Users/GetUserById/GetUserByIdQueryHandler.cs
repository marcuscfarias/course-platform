using Application.Common.Mediator;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Features.Users.GetUserById;

public class GetUserByIdQueryHandler(IUserRepository userRepository)
    : IRequestHandler<GetUserByIdQuery, GetUserByIdViewModel?>
{
    public async Task<GetUserByIdViewModel?> HandleAsync(GetUserByIdQuery request,
        CancellationToken cancellationToken = default)
    {
        var user = await userRepository.GetByIdAsync(request.Id);

        if (user is null)
            return null;

        return user.ToUserViewModel();
    }
}