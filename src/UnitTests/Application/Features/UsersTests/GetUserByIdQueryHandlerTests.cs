using Application.Features.Users.Contracts;
using Application.Features.Users.Services;
using Domain.Entities;
using Domain.Repositories;
using FluentAssertions;
using Moq;

namespace UnitTests.Application.Features.UsersTests;

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
        GetUserByIdRequest query = new(randomId);
        User? user = null;

        _userRepository
            .Setup(x => x.GetByIdAsync(randomId))
            .ReturnsAsync(user);

        //act
        var result = await _userServices.GetUser(query);

        //assert
        result.Should().BeNull();
        _userRepository.Verify(x => x.GetByIdAsync(randomId), Times.Once);
    }

    [Fact]
    public async Task Handler_UserExists_ShouldReturnUserViewModel()
    {
        //arrange
        int randomId = new Random().Next(1, Int32.MaxValue);
        GetUserByIdRequest query = new(randomId);
        User user = new User("TestingName");
        
        _userRepository
            .Setup(x => x.GetByIdAsync(randomId))
            .ReturnsAsync(user);
    
        //act
        GetUserByIdResponse? result = await _userServices.GetUser(query);
        
        //assert
        result.Should().NotBeNull();
        _userRepository.Verify(x => x.GetByIdAsync(randomId), Times.Once);
    }
}