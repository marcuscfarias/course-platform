using Application.Features.Users.Contracts;
using Application.Features.Users.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController(IUserServices userServices) : ControllerBase
{
    //TODO: functionalities
    // Register with email
    // deactivate
    // Login and Logout
    // Update role
    // recover password

    [HttpPost]
    public async Task<IActionResult> Register([FromBody] CreateUserRequest request)
    {
        int newId = await userServices.CreateUser(request);

        return new ObjectResult(newId);
    }
}