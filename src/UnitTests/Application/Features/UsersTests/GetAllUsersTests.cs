using Application.Features.Users.Services;
using Domain.Entities;
using Domain.Repositories;
using Moq;

namespace UnitTests.Application.Features.UsersTests;

public class GetAllUsersTests
{
    private readonly Mock<IUserRepository> _userRepository;
    private readonly IUserServices _userServices;

    public GetAllUsersTests()
    {
        _userRepository = new Mock<IUserRepository>();
        _userServices = new UserServices(_userRepository.Object);
    }

    // public Task HandleAsync_HaveUsers_ShouldReturnUsers()
    // {
    //     //arrange
    //     var users = new List<User> { new User("TestUser") };
    //     _userRepository
    //         .Setup(x => x.GetAllAsync())
    //         .ReturnsAsync(users);
    //     
    //     //act
    //     // var result = await _userServices.GetUser();
    //
    //     //assert
    // }
}