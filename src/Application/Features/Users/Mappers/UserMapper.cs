using Application.Features.Users.Contracts;
using Domain.Entities;

namespace Application.Features.Users.Mappers;

public static class UserMapper
{
    public static User ToDomain(this CreateUserRequest request)
    {
        return new User(request.Name);
    }

    public static GetUserByIdResponse ToUserViewModel(this User user)
    {
        return new GetUserByIdResponse(user.Id, user.Name);
    }

    public static User ToDomain(this UpdateUserRequest request)
    {
        return new User(request.Name);
    }
}