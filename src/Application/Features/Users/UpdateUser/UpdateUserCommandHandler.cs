using Application.Common.Mediator;
using Domain.Repositories;

namespace Application.Features.Users.UpdateUser;

public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, int>
{
    private readonly IUserRepository _userRepository;

    public UpdateUserCommandHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<int> HandleAsync(UpdateUserCommand request, CancellationToken cancellationToken = default)
    {
        // var user = request.ToDomain();

        var user = await _userRepository.GetByIdAsync(request.Id);

        user.ChangeName(request.Name);
        
        await _userRepository.UpdateAsync(user);
        
        
        return 1;
    }
}