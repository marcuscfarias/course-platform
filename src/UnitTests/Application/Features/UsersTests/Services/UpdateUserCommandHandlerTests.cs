using Application.Features.Users.Contracts;
using Application.Features.Users.Services;
using Domain.Entities;
using Domain.Repositories;
using FluentAssertions;
using Moq;

namespace UnitTests.Application.Features.UsersTests.Services;

public class UpdateUserCommandHandlerTests
{
    private readonly Mock<IUserRepository> _userRepository;
    private readonly IUserServices _userServices;

    public UpdateUserCommandHandlerTests()
    {
        _userRepository = new Mock<IUserRepository>();
        _userServices = new UserServices(_userRepository.Object);
    }

    [Fact]
    public async Task HandleAsync_ValidUser_ShouldUpdateUser()
    {
        // Arrange
        int randomId = new Random().Next(1, Int32.MaxValue);
        string newName = "UpdatedName";
        User existingUser = new("OldName");

        var updateCommand = new UpdateUserRequest(newName);

        _userRepository
            .Setup(x => x.GetByIdAsync(randomId))
            .ReturnsAsync(existingUser);

        _userRepository
            .Setup(x => x.UpdateAsync(existingUser));

        // Act
        await _userServices.UpdateUser(randomId, updateCommand);

        // Assert
        _userRepository.Verify(x => x.GetByIdAsync(randomId), Times.Once);
        _userRepository.Verify(x => x.UpdateAsync(existingUser), Times.Once);
        existingUser.Name.Should().Be(newName);
    }
}