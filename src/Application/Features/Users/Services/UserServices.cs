using Application.Features.Users.Contracts;
using Application.Features.Users.Mappers;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Features.Users.Services;

public class UserServices(IUserRepository userRepository) : IUserServices
{
    public async Task<GetUserByIdResponse> GetUser(GetUserByIdRequest request,
        CancellationToken cancellationToken = default)
    {
        var user = await userRepository.GetByIdAsync(request.Id);

        if (user is null)
            return null;

        return user.ToUserViewModel();
    }

    public async Task<int> CreateUser(CreateUserRequest request, CancellationToken cancellationToken = default)
    {
        var user = request.ToDomain();

        var id = await userRepository.AddAsync(user);

        return id;
    }

    public async Task UpdateUser(UpdateUserRequest request, CancellationToken cancellationToken = default)
    {
        // var user = request.ToDomain();

        var user = await userRepository.GetByIdAsync(request.Id);

        user.ChangeName(request.Name);

        await userRepository.UpdateAsync(user);
    }

    public async Task DeleteUser(int id, CancellationToken cancellationToken = default)
    {
        var user = await userRepository.GetByIdAsync(id);

        user.Deactivate();

        await userRepository.DeleteAsync(user);
    }
}