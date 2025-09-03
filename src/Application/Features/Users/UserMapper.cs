using Application.Features.Users.CreateUser;

namespace Application.Features.Users;

public static class UserMapper
{
    public static Domain.Entities.User ToDomain(this CreateUserCommand command)
    {
        return new Domain.Entities.User(command.Name);
    }
}