using Application.Features.Users.GetUserById;
using Domain.Entities;
using Domain.Repositories;
using FluentAssertions;
using Moq;

namespace UnitTests.Application.UserTests;

public class GetUserByIdQueryHandlerTests
{
    private readonly Mock<IUserRepository> _userRepository;
    private readonly GetUserByIdQueryHandler _handler;

    public GetUserByIdQueryHandlerTests()
    {
        _userRepository = new Mock<IUserRepository>();
        _handler = new GetUserByIdQueryHandler(_userRepository.Object);
    }

    [Fact]
    public async Task Handler_UserNotExists_ShouldReturnNull()
    {
        //arrange
        int randomId = new Random().Next(1, Int32.MaxValue);
        GetUserByIdQuery query = new(randomId);
        User? user = null;

        _userRepository
            .Setup(x => x.GetByIdAsync(randomId))
            .ReturnsAsync(user);

        //act
        var result = await _handler.HandleAsync(query);

        //assert
        result.Should().BeNull();
        _userRepository.Verify(x => x.GetByIdAsync(randomId), Times.Once);
    }

    [Fact]
    public async Task Handler_UserExists_ShouldReturnUserViewModel()
    {
        //arrange
        int randomId = new Random().Next(1, Int32.MaxValue);
        GetUserByIdQuery query = new(randomId);
        User user = new User("TestingName");
        
        _userRepository
            .Setup(x => x.GetByIdAsync(randomId))
            .ReturnsAsync(user);
    
        //act
        GetUserByIdViewModel? result = await _handler.HandleAsync(query);
        
        //assert
        result.Should().NotBeNull();
        _userRepository.Verify(x => x.GetByIdAsync(randomId), Times.Once);
    }
}