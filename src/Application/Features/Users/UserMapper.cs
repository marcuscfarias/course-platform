using Application.Features.Users.CreateUser;
using Application.Features.Users.GetUserById;
using Application.Features.Users.UpdateUser;
using Domain.Entities;

namespace Application.Features.Users;

public static class UserMapper
{
    public static User ToDomain(this CreateUserCommand command)
    {
        return new User(command.Name);
    }

    public static GetUserByIdViewModel ToUserViewModel(this User user)
    {
        return new GetUserByIdViewModel(user.Name);
    }

    public static User ToDomain(this UpdateUserCommand request)
    {
        return new User(request.Name);
    }
}