namespace Application.Features.Users.Contracts;

public record GetUserByIdRequest(int Id);

public record GetUserByIdResponse(int Id, string Name);