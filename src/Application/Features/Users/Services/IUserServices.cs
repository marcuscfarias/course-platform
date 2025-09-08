using Application.Features.Users.Contracts;
using Domain.Entities;

namespace Application.Features.Users.Services;

//TODO: refactor userServices tests
public interface IUserServices
{
    Task<GetUserByIdResponse> GetUser(int id, CancellationToken cancellationToken = default);
    Task<int> CreateUser(CreateUserRequest user, CancellationToken cancellationToken = default);
    Task UpdateUser(int id, UpdateUserRequest request, CancellationToken cancellationToken = default);
    Task DeleteUser(int id, CancellationToken cancellationToken = default); 
}