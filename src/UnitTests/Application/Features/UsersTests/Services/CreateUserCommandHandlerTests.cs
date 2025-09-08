using Application.Features.Users.Contracts;
using Application.Features.Users.Services;
using Bogus;
using Domain.Entities;
using Domain.Repositories;
using FluentAssertions;
using Moq;

namespace UnitTests.Application.Features.UsersTests.Services;

public class CreateUserCommandHandlerTests
{
    private readonly Mock<IUserRepository> _userRepository;
    private readonly IUserServices _userServices;

    public CreateUserCommandHandlerTests()
    {
        _userRepository = new Mock<IUserRepository>();
        _userServices = new UserServices(_userRepository.Object);
    }

    // MethodName_StateUnderTest_ExpectedBehavior
    [Fact]
    public async Task Handler_ValidUser_ShouldReturnId()
    {
        //arrange
        int randomId = new Random().Next(1, Int32.MaxValue);
        CreateUserRequest command = CreateUserCommandFake();

        _userRepository
            .Setup(x => x.AddAsync(It.IsAny<User>()))
            .ReturnsAsync(randomId);

        //act
        var result = await _userServices.CreateUser(command);

        //assert
        result.Should().Be(randomId);
        _userRepository.Verify(x => x.AddAsync(It.IsAny<User>()), Times.Once);
    }

    //TODO: add user already exists
    //TODO: add invalid request

    private static CreateUserRequest CreateUserCommandFake()
    {
        var faker = new Faker<CreateUserRequest>()
            .CustomInstantiator(f =>
                new CreateUserRequest(f.Name.FullName()));

        return faker.Generate();
    }
}