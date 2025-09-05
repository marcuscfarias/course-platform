using Application.Features.Users.Contracts;
using Domain.Entities;

namespace Application.Features.Users.Services;

public interface IUserServices
{
    Task<GetUserByIdResponse> GetUser(GetUserByIdRequest request, CancellationToken cancellationToken = default);
    Task<int> CreateUser(CreateUserRequest user, CancellationToken cancellationToken = default);
    Task UpdateUser(UpdateUserRequest request, CancellationToken cancellationToken = default);
    Task DeleteUser(int id, CancellationToken cancellationToken = default); 
}