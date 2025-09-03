using Application.Common.Mediator;
using Moq;
using Application.Features.Users.CreateUser;
using Bogus;
using Domain.Repositories;
using Domain.Entities;
using FluentAssertions;

namespace UnitTests.Application.UserTests;


public class CreateUserCommandHandlerTests
{
    private readonly Mock<IUserRepository> _userRepository;
    private readonly CreateUserCommandHandler _handler;

    public CreateUserCommandHandlerTests()
    {
        _userRepository = new Mock<IUserRepository>();
        _handler  = new CreateUserCommandHandler(_userRepository.Object);
    }

    // MethodName_StateUnderTest_ExpectedBehavior
    [Fact]
    public async Task Handler_ValidUser_ShouldReturnId()
    {
        //arrange
        int randomId = new Random().Next(1, Int32.MaxValue);
        CreateUserCommand command = CreateUserCommandFake();

        _userRepository
            .Setup(x => x.AddAsync(It.IsAny<User>()))
            .ReturnsAsync(randomId);

        //act
        var result = await _handler.HandleAsync(command);

        //assert
        result.Should().Be(randomId);
        _userRepository.Verify(x => x.AddAsync(It.IsAny<User>()), Times.Once);
    }
    
    //TODO: add user already exists
    //TODO: add invalid request

    private static CreateUserCommand CreateUserCommandFake()
    {
        var faker = new Faker<CreateUserCommand>()
            .CustomInstantiator(f =>
                new CreateUserCommand(f.Name.FullName()));

        return faker.Generate();
    }
}