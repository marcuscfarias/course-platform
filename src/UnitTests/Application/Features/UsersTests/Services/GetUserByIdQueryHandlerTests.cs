using Application.Features.Users.Contracts;
using Application.Features.Users.Services;
using Domain.Entities;
using Domain.Repositories;
using FluentAssertions;
using Moq;

namespace UnitTests.Application.Features.UsersTests.Services;

public class GetUserByIdQueryHandlerTests
{
    private readonly Mock<IUserRepository> _userRepository;
    private readonly IUserServices _userServices;

    public GetUserByIdQueryHandlerTests()
    {
        _userRepository = new Mock<IUserRepository>();
        _userServices = new UserServices(_userRepository.Object);
    }

    [Fact]
    public async Task Handler_UserNotExists_ShouldReturnNull()
    {
        //arrange
        int randomId = new Random().Next(1, Int32.MaxValue);
        User? user = null;

        _userRepository
            .Setup(x => x.GetByIdAsync(randomId))
            .ReturnsAsync(user);

        //act
        var result = await _userServices.GetUser(randomId);

        //assert
        result.Should().BeNull();
        _userRepository.Verify(x => x.GetByIdAsync(randomId), Times.Once);
    }

    [Fact]
    public async Task Handler_UserExists_ShouldReturnUserViewModel()
    {
        //arrange
        int randomId = new Random().Next(1, Int32.MaxValue);
        User user = new User("TestingName");
        
        _userRepository
            .Setup(x => x.GetByIdAsync(randomId))
            .ReturnsAsync(user);
    
        //act
        GetUserByIdResponse? result = await _userServices.GetUser(randomId);
        
        //assert
        result.Should().NotBeNull();
        _userRepository.Verify(x => x.GetByIdAsync(randomId), Times.Once);
    }
}