using Application.Features.Users.UpdateUser;
using Domain.Entities;
using Domain.Repositories;
using FluentAssertions;
using Moq;

namespace UnitTests.Application.UserTests;

public class UpdateUserCommandHandlerTests
{
    private readonly Mock<IUserRepository> _userRepository;
    private readonly UpdateUserCommandHandler _handler;

    public UpdateUserCommandHandlerTests()
    {
        _userRepository = new Mock<IUserRepository>();
        _handler = new UpdateUserCommandHandler(_userRepository.Object);
    }

    [Fact]
    public async Task HandleAsync_ValidUser_ShouldUpdateUser()
    {
        // Arrange
        int randomId = new Random().Next(1, Int32.MaxValue);
        string newName = "UpdatedName";
        User existingUser = new("OldName");

        var updateCommand = new UpdateUserCommand(randomId, newName);

        _userRepository
            .Setup(x => x.GetByIdAsync(randomId))
            .ReturnsAsync(existingUser);

        _userRepository
            .Setup(x => x.UpdateAsync(existingUser))
            .ReturnsAsync(true);

        // Act
        var result = await _handler.HandleAsync(updateCommand);

        // Assert
        _userRepository.Verify(x => x.GetByIdAsync(randomId), Times.Once);
        _userRepository.Verify(x => x.UpdateAsync(existingUser), Times.Once);
        existingUser.Name.Should().Be(newName);
        Assert.Equal(1, result); 
    }
}