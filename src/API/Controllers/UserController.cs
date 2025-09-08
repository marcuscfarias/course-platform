using Application.Features.Users.Contracts;
using Application.Features.Users.Services;
using Microsoft.AspNetCore.Http.HttpResults;
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

        return CreatedAtAction(nameof(GetById), new { id = newId }, request);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] int id)
    {
        GetUserByIdResponse userResponse = await userServices.GetUser(id);

        return Ok(userResponse);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update([FromRoute] int id, UpdateUserRequest request)
    {
        await userServices.UpdateUser(id, request);

        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        await userServices.DeleteUser(id);
        return Ok();
    }
}